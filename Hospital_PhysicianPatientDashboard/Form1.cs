using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using ClosedXML.Excel;
namespace Hospital_PhysicianPatientDashboard
{
    public partial class PhysicianPatientDashboard : Form
    {
        public DataTable physiciansData;
        public PhysicianPatientDashboard()
        {
            InitializeComponent();
        }

        //config string to connect to database
        string cofig = ConfigurationManager.ConnectionStrings["lrch_db"].ConnectionString;


        //Method to Load Patient Records from Database
        void LoadPatientRecords()
        {
            SqlConnection con = new SqlConnection(cofig);
            SqlCommand command = new SqlCommand("SELECT * FROM LRC_Hospital_Database.dbo.Patient", con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            physiciansData = dataTable;
            dataGridViewPatientDetails.DataSource = dataTable;

        }

        //Method to Load Treatment Record from Database
        void LoadTreatmentRecord()
        {
            SqlConnection con = new SqlConnection(cofig);
            SqlCommand cmdSelectTreatment = new SqlCommand("select * from Treatment where Convert(varchar(10),admission_id)='" + txtAdmissionId.Text + "'", con);

            SqlDataAdapter data = new SqlDataAdapter(cmdSelectTreatment);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            dataGridViewTreatment.DataSource = dataTable;

        }

        //Method to Load Patient Note from Database
        void LoadPatientNote()
        {
            SqlConnection con = new SqlConnection(cofig);
            SqlCommand cmdSelect = new SqlCommand("select * from Patient_Notes where patient_number='" + txtPatientNumber.Text + "'", con);

            SqlDataAdapter data = new SqlDataAdapter(cmdSelect);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            dataGridViewNotes.DataSource = dataTable;

        }

        //when Assign btn clicked
        private void btnAssignTreatment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdmissionId.Text) || string.IsNullOrEmpty(richtxtTreatmentDescription.Text))
            {
                MessageBox.Show("You must enter in both fields.");
            }
            else
            {
                SqlConnection con = new SqlConnection(cofig);
                con.Open();
                //converting the id's data type in the following query so that it does't give null error
                SqlCommand cmdCheckAddmissionId = new SqlCommand("select Convert(varchar(10),admission_id) from Treatment where Convert(varchar(10),admission_id)='" + txtAdmissionId.Text + "'", con);

                string addmissionId = (string)cmdCheckAddmissionId.ExecuteScalar();
                con.Close();
                //if the data base admission_id doesn't equal to what the user put in the Admission Id TextBox
                if (addmissionId != txtAdmissionId.Text)
                {
                    //then pop up the following error message
                    MessageBox.Show("Error: This Addmission Id does not exist in the database");
                }
                //otherwise it's valid so,
                else
                {
                    //open the con agian
                    con.Open();
                    //using a stored procudure to insert what the user entered into the databaase
                    SqlCommand command = new SqlCommand("exec dbo.SP_Assign_Treatment '" + int.Parse(txtAdmissionId.Text) + "', '" + richtxtTreatmentDescription.Text + "'", con);
                    command.ExecuteNonQuery();
                    //then display Successfull message and close the connection
                    MessageBox.Show("Successfully Assigned");
                    con.Close();
                }
                LoadTreatmentRecord();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientNumber.Text) || string.IsNullOrEmpty(richTxtBoxNotes.Text))
            {
                MessageBox.Show("You must enter in Both the Patient Number and the Note feild.");
            }
            else
            {
                SqlConnection con = new SqlConnection(cofig);
                con.Open();
                //converting the id's data type in the following query so that it does't give null error
                SqlCommand cmdCheckId = new SqlCommand("select Convert(varchar(10),patient_number) from Patient_Notes where Convert(varchar(10),patient_number)='" + txtPatientNumber.Text + "'", con);

                string id = (string)cmdCheckId.ExecuteScalar();
                con.Close();
                //if the data base patient_number doesn't equal to what the user put in the TextBox
                if (id != txtPatientNumber.Text)
                {
                    //then pop up the following error message
                    MessageBox.Show("Error: This Patient Number does not exist in the database");
                }
                //otherwise it's valid so,
                else
                {
                    //open the con agian
                    con.Open();
                    //using a stored procudure to insert what the user entered into the databaase
                    SqlCommand command = new SqlCommand("exec dbo.SP_Add_Notes '" + int.Parse(txtPatientNumber.Text) + "', '" + richTxtBoxNotes.Text + "'", con);
                    command.ExecuteNonQuery();
                    //then display Successfull message and close the connection
                    MessageBox.Show("Successfully Added");
                    LoadPatientNote();
                    con.Close();

                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.Filter = "Excel WorkBook (.xlsx)|*.xlsx";
            saveFileDialog.ShowDialog();


            if (string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                return;
            }


            // Create a new workbook
            var workbook = new XLWorkbook();

            // Add a worksheet to the workbook
            var worksheet = workbook.Worksheets.Add("Sheet1");

            // Get the data from the DataGrid

            worksheet.Cell(1, 1).Value = "Patient Number";
            worksheet.Cell(1, 2).Value = "Health Card Number";
            worksheet.Cell(1, 3).Value = "Patient Name";
            worksheet.Cell(1, 4).Value = "Patient Phone";
            worksheet.Cell(1, 5).Value = "Patient Address";
            worksheet.Cell(1, 6).Value = "City";
            worksheet.Cell(1, 7).Value = "Postal Code";
            worksheet.Cell(1, 8).Value = "Province";
            worksheet.Cell(1, 9).Value = "Sex";
            worksheet.Cell(1, 10).Value = "Extension";
            worksheet.Cell(1, 11).Value = "Finnancial Source";

            // Loop through the rows and columns of the DataGrid and add them to the worksheet
            for (int row = 0; row < physiciansData.Rows.Count; row++)
            {
                for (int col = 0; col < physiciansData.Columns.Count; col++)
                {
                    // Get the value of the cell
                    string value = physiciansData.Rows[row][col].ToString();

                    // Add the value to the worksheet
                    worksheet.Cell(row + 2, col + 1).Value = value;
                }
            }

            // Save the workbook to a file
            workbook.SaveAs(saveFileDialog.FileName);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhysicianNumber.Text))
            {
                MessageBox.Show("Please enter your Physician Number to view your Patients.");
            }
            else
            {
                SqlConnection con = new SqlConnection(cofig);
                con.Open();
                //converting the id's data type in the following query so that it does't give null error
                SqlCommand cmdCheckPhysicianIdId = new SqlCommand("select Convert(varchar(10),physician_number) from Physician where Convert(varchar(10),physician_number)='" + txtPhysicianNumber.Text + "'", con);

                string physicianId = (string)cmdCheckPhysicianIdId.ExecuteScalar();
                con.Close();

                //if the data base admission_id doesn't equal to what the user put in the Admission Id TextBox
                if (physicianId != txtPhysicianNumber.Text)
                {
                    //then pop up the following error message
                    MessageBox.Show("Error: The Physician Id entered does not exist in the database.");
                }
                //otherwise it's valid so,
                else
                {
                    LoadPatientRecords();
                }
            }
        }
    }
}