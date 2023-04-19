using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Configurations;
using ClosedXML.Excel;

namespace RoomUtilDashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection connection;
        List<RoomOverallOccupancy> bedsOverallOccupancy = new List<RoomOverallOccupancy>();
        public SeriesCollection OverallRoomType {get; set;}
        public MainWindow()
        {
            InitializeComponent();
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LRC_Hospital_Database;Integrated Security=True";
            string connectionString = "Data Source = DESKTOP-SU2PRSQ\\SQL; Initial Catalog = LRC_Hospital_Database; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch(Exception e)
            {
                return;
            }

            RunQueires();
        }


        private void RunQueires()
        {
            bedsOverallOccupancy = new List<RoomOverallOccupancy>();
            OverallBeds();
            OverallRooms();
            OverallRoomTypeQuery();
            EmptyRoomsByTypeQuery();
            DischargeTodayQuery();
        }


        public void PrintClicked(object sender, RoutedEventArgs e)
        {

            var saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.Filter = "Excel WorkBook (.xlsx)|*.xlsx";
            Nullable<bool> result = saveFileDialog.ShowDialog();


            if(result != true && string.IsNullOrEmpty(saveFileDialog.FileName)){
                return;
            }


             // Create a new workbook
            var workbook = new XLWorkbook();

            // Add a worksheet to the workbook
            var worksheet = workbook.Worksheets.Add("Sheet1");

            // Get the data from the DataGrid
            var data = roomGrid.ItemsSource.Cast<object>().ToList();

            worksheet.Cell(1, 1).Value = "Location";
            worksheet.Cell(1, 2).Value = "Type";
            worksheet.Cell(1, 3).Value = "Paitient No";
            worksheet.Cell(1, 4).Value = "Paitient Name";
            worksheet.Cell(1, 5).Value = "Date Admitted";

            // Loop through the rows and columns of the DataGrid and add them to the worksheet
            for (int row = 0; row < data.Count; row++)
            {
                for (int col = 0; col < roomGrid.Columns.Count; col++)
                {
                    // Get the value of the cell
                    var value = roomGrid.Columns[col].GetCellContent(data[row]);
                    var somehintg = (TextBlock) value;

                    // Add the value to the worksheet
                    worksheet.Cell(row + 2, col + 1).Value = somehintg.Text;
                }
            }

            // Save the workbook to a file
            workbook.SaveAs(saveFileDialog.FileName);
        }

        public void DischargeTodayQuery()
        {
            string emptinesOfRoomByTypes = @"
            SELECT COUNT(*) as num_beds_discharged_today
            FROM AdmissionHistory AS ah
            JOIN Bed AS b ON ah.bed_id = b.bed_id
            WHERE CONVERT(date, ah.discharge_date) = CONVERT(date, GETDATE())
            ";

            using SqlCommand command = new SqlCommand(emptinesOfRoomByTypes, connection);

            using SqlDataReader reader = command.ExecuteReader();
            double pr = 0;

            while(reader.Read())
            {
                DischargeToday.Content = "" + reader.GetInt32(0);
            }
        }

        public void RefreshClicked(object sender, RoutedEventArgs e)
        {
            RunQueires();
        }

        public void EmptyRoomsByTypeQuery()
        {
            string emptinesOfRoomByTypes = @"
            SELECT room_type,
                    1 - COUNT(CASE WHEN bed_availability = 0 THEN bed_number END) * 1.0 / COUNT(bed_number) AS empty_room_percentage
            FROM Room
            LEFT JOIN Bed ON Room.room_number = Bed.room_number
            GROUP BY room_type;
            ";


            using SqlCommand command = new SqlCommand(emptinesOfRoomByTypes, connection);

            using SqlDataReader reader = command.ExecuteReader();
            double pr = 0;
            double sp = 0;
            double ic = 0;
            double w3 = 0;
            double w4 = 0;
            while(reader.Read())
            {
                string type = reader.GetString(0);
                double emptyness = ((double) reader.GetDecimal(1)) * 100;

                if(type == "PR")
                {
                    pr = emptyness;
                }

                if(type == "SP")
                {
                    sp = emptyness;
                }

                if(type == "IC")
                {
                    ic = emptyness;
                }

                if(type == "W3")
                {
                    w3 = emptyness;
                }
                
                if(type == "W4")
                {
                    w4 = emptyness;
                }
              
            }

            emptyRooms.Series.Clear();

            emptyRooms.Series.Add(new PieSeries
            {
                Title = "PR",
                DataLabels = true,
                LabelPoint = chartPoint => string.Format("PR {0}%", chartPoint.Y),
                Values = new ChartValues<double>{pr}
            });
            emptyRooms.Series.Add(new PieSeries
            {
                Title = "SP",

                LabelPoint = chartPoint => string.Format("SP {0}%", chartPoint.Y),
                DataLabels = true,
                Values = new ChartValues<double>{sp}
            });

            emptyRooms.Series.Add(new PieSeries
            {
                Title = "IC",

                LabelPoint = chartPoint => string.Format("IC {0}%", chartPoint.Y),
                DataLabels = true,
                Values = new ChartValues<double>{ic}
            });


            emptyRooms.Series.Add(new PieSeries
            {
                Title = "W3",
                LabelPoint = chartPoint => string.Format("W3 {0}%", chartPoint.Y),
                DataLabels = true,
                Values = new ChartValues<double>{w3}
            });


            emptyRooms.Series.Add(new PieSeries
            {
                Title = "W4",
                LabelPoint = chartPoint => string.Format("W4 {0}%", chartPoint.Y),
                DataLabels = true,
                Values = new ChartValues<double>{w4}
            });
        }

        public void OverallRoomTypeQuery()
        {

            string occupancyByRoomsType = @"
                 SELECT Room.room_number, Room.room_type, Bed.bed_number,
                       CASE WHEN Bed.bed_availability = 0 THEN Patient.patient_number ELSE NULL END AS current_patient_no,
                       CASE WHEN Bed.bed_availability = 0 THEN AdmissionHistory.date_admitted ELSE NULL END AS current_patient_admission_date,
                       CASE WHEN Bed.bed_availability = 0 THEN Patient.patient_name ELSE NULL END AS current_patient_name
                FROM Room
                LEFT JOIN Bed ON Room.room_number = Bed.room_number
                LEFT JOIN (
                  SELECT AdmissionHistory.bed_id, AdmissionHistory.patient_number, AdmissionHistory.date_admitted
                  FROM AdmissionHistory
                  WHERE AdmissionHistory.discharge_date IS NULL
                ) AS AdmissionHistory ON Bed.bed_id = AdmissionHistory.bed_id
                LEFT JOIN Patient ON AdmissionHistory.patient_number = Patient.patient_number
                ORDER BY Room.room_number, Bed.bed_number
            ";

            using SqlCommand command = new SqlCommand(occupancyByRoomsType, connection);

            using SqlDataReader reader = command.ExecuteReader();
            int pr = 0;
            int sp = 0;
            int ic = 0;
            int w3 = 0;
            int w4 = 0;
            while(reader.Read())
            {
                string type = reader.GetString(1);
                bool available = reader.IsDBNull(3);
                if(type == "PR")
                {
                    if(!available)
                    {
                        pr++;
                    }
                }


                if(type == "SP")
                {
                    if(!available)
                    {
                        sp++;
                    }
                }


                if(type == "IC")
                {
                    if(!available)
                    {
                        ic++;
                    }
                }


                if(type == "W3")
                {
                    if(!available)
                    {
                        w3++;
                    }
                }


                if(type == "W4")
                {
                    if(!available)
                    {
                        w4++;
                    }
                }

            }

            overallRoomTypeChart.Series.Clear();
            overallRoomTypeChart.AxisX.Clear();
            overallRoomTypeChart.Series.Add(new ColumnSeries
                {
                    Title = "PR",
                    Values = new ChartValues<int> {pr} 
                }
            );


            overallRoomTypeChart.Series.Add(new ColumnSeries
                {
                    Title = "SP",
                    Values = new ChartValues<int> {sp} 
                }
            );

            overallRoomTypeChart.Series.Add(new ColumnSeries
                {
                    Title = "IC",
                    Values = new ChartValues<int> {ic} 
                }
            );

            overallRoomTypeChart.Series.Add(new ColumnSeries
                {
                Title = "W3",
                Values = new ChartValues<int> { w3 }
                }
            );
            overallRoomTypeChart.Series.Add(new ColumnSeries
                {
                Title = "W4",
                Values = new ChartValues<int> { w4 }
                }
            );

            overallRoomTypeChart.AxisX.Add(new Axis
            {
                Title = "Room Types",
                Labels = new string[] {""}
            });


            DataContext = this;

       
        }

        public void OverallRooms()
        {
            string occupancyByRooms = @"
                SELECT room_availability FROM Room
            ";

            using SqlCommand command = new SqlCommand(occupancyByRooms, connection);

            using SqlDataReader reader = command.ExecuteReader();
            int occupied = 0;
            int notOccupied = 0;

            while(reader.Read())
            {
                if(reader.GetBoolean(0))
                {
                    notOccupied++;
                }
                else
                {
                    occupied++;
                }
            }

            overallRooms.Series.Clear();

            overallRooms.Series.Add(new PieSeries
            {
                Title = "Not Occupied",

                DataLabels = true,
                LabelPoint = chartPoint => string.Format("Not Occupied {0}", chartPoint.Y),
                Values = new ChartValues<int>{notOccupied}
            });
            overallRooms.Series.Add(new PieSeries
            {
                Title = "Occupied",

                DataLabels = true,
                LabelPoint = chartPoint => string.Format("Occupied {0}", chartPoint.Y),
                Values = new ChartValues<int>{occupied}
            });
        }

        public void OverallBeds()
        {
            string occupancyByBeds = @"
                SELECT Room.room_number, Room.room_type, Bed.bed_number,
                       CASE WHEN Bed.bed_availability = 0 THEN Patient.patient_number ELSE NULL END AS current_patient_no,
                       CASE WHEN Bed.bed_availability = 0 THEN AdmissionHistory.date_admitted ELSE NULL END AS current_patient_admission_date,
                       CASE WHEN Bed.bed_availability = 0 THEN Patient.patient_name ELSE NULL END AS current_patient_name
                FROM Room
                LEFT JOIN Bed ON Room.room_number = Bed.room_number
                LEFT JOIN (
                  SELECT AdmissionHistory.bed_id, AdmissionHistory.patient_number, AdmissionHistory.date_admitted
                  FROM AdmissionHistory
                  WHERE AdmissionHistory.discharge_date IS NULL
                ) AS AdmissionHistory ON Bed.bed_id = AdmissionHistory.bed_id
                LEFT JOIN Patient ON AdmissionHistory.patient_number = Patient.patient_number
                ORDER BY Room.room_number, Bed.bed_number
            ";

            using SqlCommand command = new SqlCommand(occupancyByBeds, connection);

            using SqlDataReader reader = command.ExecuteReader();
            int occupied = 0;
            int notOccupied = 0;

            while(reader.Read())
            {
                var room12 = reader.GetInt32(0);
                var bed12 =  reader.GetString(2);
                string loc = reader.GetInt32(0) + "-" + reader.GetString(2);
                string patientno = reader.IsDBNull(3) ? "" : reader.GetInt32(3) + "";
                string dateAdmitted = reader.IsDBNull(4) ? "" : reader.GetDateTime(4).ToString("yyyy-MM-dd");
                string patientName = reader.IsDBNull(5) ? "" : reader.GetString(5);
                RoomOverallOccupancy room = new RoomOverallOccupancy(loc, reader.GetString(1), patientno, patientName, dateAdmitted);
                bedsOverallOccupancy.Add(room);
                if(reader.IsDBNull(3))
                {
                    notOccupied++;
                }
                else
                {
                    occupied++;
                }
            }
            roomGrid.ItemsSource = bedsOverallOccupancy;

            overallBeds.Series.Clear();

            overallBeds.Series.Add(new PieSeries
            {
                Title = "Not Occupied",

                DataLabels = true,
                LabelPoint = chartPoint => string.Format("Not Occupied {0}", chartPoint.Y),
                Values = new ChartValues<int>{notOccupied}
            });
            overallBeds.Series.Add(new PieSeries
            {
                Title = "Occupied",
                LabelPoint = chartPoint => string.Format("Occupied {0}", chartPoint.Y),
                DataLabels = true,
                Values = new ChartValues<int>{occupied}
            });
        }
    }
}
