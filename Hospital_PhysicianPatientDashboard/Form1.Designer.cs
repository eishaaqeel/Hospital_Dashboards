namespace Hospital_PhysicianPatientDashboard
{
    partial class PhysicianPatientDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysicianPatientDashboard));
            tabsPhysicianPatient = new TabControl();
            tabViewPatientDetails = new TabPage();
            btnView = new Button();
            txtPhysicianNumber = new TextBox();
            lblPhysicianNumber = new Label();
            lblPatientDetsTitle = new Label();
            btnPrint = new Button();
            dataGridViewPatientDetails = new DataGridView();
            tabAssignTreatments = new TabPage();
            lblPatientsTreatment = new Label();
            pictureBoxHealth = new PictureBox();
            dataGridViewTreatment = new DataGridView();
            btnAssignTreatment = new Button();
            richtxtTreatmentDescription = new RichTextBox();
            txtAdmissionId = new TextBox();
            lblTreatmentDescription = new Label();
            lblAdmissionId = new Label();
            lblAssignTreatment = new Label();
            tabAddPatientNotes = new TabPage();
            txtPatientNumber = new TextBox();
            lblPatientNumber = new Label();
            lblSubheadingNotes = new Label();
            dataGridViewNotes = new DataGridView();
            btnAdd = new Button();
            richTxtBoxNotes = new RichTextBox();
            lblNotes = new Label();
            lblTitleNote = new Label();
            pictureBoxNotes = new PictureBox();
            tabsPhysicianPatient.SuspendLayout();
            tabViewPatientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatientDetails).BeginInit();
            tabAssignTreatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHealth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).BeginInit();
            tabAddPatientNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNotes).BeginInit();
            SuspendLayout();
            // 
            // tabsPhysicianPatient
            // 
            tabsPhysicianPatient.Controls.Add(tabViewPatientDetails);
            tabsPhysicianPatient.Controls.Add(tabAssignTreatments);
            tabsPhysicianPatient.Controls.Add(tabAddPatientNotes);
            tabsPhysicianPatient.Dock = DockStyle.Fill;
            tabsPhysicianPatient.ItemSize = new Size(130, 20);
            tabsPhysicianPatient.Location = new Point(0, 0);
            tabsPhysicianPatient.Name = "tabsPhysicianPatient";
            tabsPhysicianPatient.SelectedIndex = 0;
            tabsPhysicianPatient.Size = new Size(665, 516);
            tabsPhysicianPatient.TabIndex = 0;
            // 
            // tabViewPatientDetails
            // 
            tabViewPatientDetails.BackColor = Color.DarkSlateGray;
            tabViewPatientDetails.Controls.Add(btnView);
            tabViewPatientDetails.Controls.Add(txtPhysicianNumber);
            tabViewPatientDetails.Controls.Add(lblPhysicianNumber);
            tabViewPatientDetails.Controls.Add(lblPatientDetsTitle);
            tabViewPatientDetails.Controls.Add(btnPrint);
            tabViewPatientDetails.Controls.Add(dataGridViewPatientDetails);
            tabViewPatientDetails.Location = new Point(4, 24);
            tabViewPatientDetails.Name = "tabViewPatientDetails";
            tabViewPatientDetails.Padding = new Padding(3);
            tabViewPatientDetails.Size = new Size(657, 488);
            tabViewPatientDetails.TabIndex = 0;
            tabViewPatientDetails.Text = "View Patient Details";
            // 
            // btnView
            // 
            btnView.BackColor = Color.MidnightBlue;
            btnView.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.ForeColor = SystemColors.ButtonFace;
            btnView.Location = new Point(8, 108);
            btnView.Name = "btnView";
            btnView.Size = new Size(90, 35);
            btnView.TabIndex = 8;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // txtPhysicianNumber
            // 
            txtPhysicianNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPhysicianNumber.Location = new Point(216, 77);
            txtPhysicianNumber.MaxLength = 32;
            txtPhysicianNumber.Name = "txtPhysicianNumber";
            txtPhysicianNumber.Size = new Size(219, 23);
            txtPhysicianNumber.TabIndex = 7;
            // 
            // lblPhysicianNumber
            // 
            lblPhysicianNumber.BackColor = Color.Transparent;
            lblPhysicianNumber.Dock = DockStyle.Top;
            lblPhysicianNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhysicianNumber.ForeColor = SystemColors.ButtonFace;
            lblPhysicianNumber.Location = new Point(3, 54);
            lblPhysicianNumber.Name = "lblPhysicianNumber";
            lblPhysicianNumber.Size = new Size(651, 20);
            lblPhysicianNumber.TabIndex = 6;
            lblPhysicianNumber.Text = "Physician Number";
            lblPhysicianNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPatientDetsTitle
            // 
            lblPatientDetsTitle.BackColor = Color.Transparent;
            lblPatientDetsTitle.Dock = DockStyle.Top;
            lblPatientDetsTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientDetsTitle.ForeColor = SystemColors.ButtonFace;
            lblPatientDetsTitle.Location = new Point(3, 3);
            lblPatientDetsTitle.Name = "lblPatientDetsTitle";
            lblPatientDetsTitle.Size = new Size(651, 51);
            lblPatientDetsTitle.TabIndex = 2;
            lblPatientDetsTitle.Text = "Patient Details";
            lblPatientDetsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(8, 431);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(113, 49);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // dataGridViewPatientDetails
            // 
            dataGridViewPatientDetails.AllowDrop = true;
            dataGridViewPatientDetails.AllowUserToAddRows = false;
            dataGridViewPatientDetails.AllowUserToDeleteRows = false;
            dataGridViewPatientDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPatientDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPatientDetails.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewPatientDetails.Location = new Point(8, 149);
            dataGridViewPatientDetails.Name = "dataGridViewPatientDetails";
            dataGridViewPatientDetails.RowTemplate.Height = 25;
            dataGridViewPatientDetails.Size = new Size(641, 276);
            dataGridViewPatientDetails.TabIndex = 0;
            // 
            // tabAssignTreatments
            // 
            tabAssignTreatments.BackColor = Color.DarkSlateGray;
            tabAssignTreatments.Controls.Add(lblPatientsTreatment);
            tabAssignTreatments.Controls.Add(pictureBoxHealth);
            tabAssignTreatments.Controls.Add(dataGridViewTreatment);
            tabAssignTreatments.Controls.Add(btnAssignTreatment);
            tabAssignTreatments.Controls.Add(richtxtTreatmentDescription);
            tabAssignTreatments.Controls.Add(txtAdmissionId);
            tabAssignTreatments.Controls.Add(lblTreatmentDescription);
            tabAssignTreatments.Controls.Add(lblAdmissionId);
            tabAssignTreatments.Controls.Add(lblAssignTreatment);
            tabAssignTreatments.Location = new Point(4, 24);
            tabAssignTreatments.Name = "tabAssignTreatments";
            tabAssignTreatments.Padding = new Padding(3);
            tabAssignTreatments.Size = new Size(657, 488);
            tabAssignTreatments.TabIndex = 1;
            tabAssignTreatments.Text = "Assign Treatment(s)";
            // 
            // lblPatientsTreatment
            // 
            lblPatientsTreatment.AutoSize = true;
            lblPatientsTreatment.BackColor = Color.Transparent;
            lblPatientsTreatment.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientsTreatment.ForeColor = SystemColors.ActiveCaption;
            lblPatientsTreatment.Location = new Point(8, 340);
            lblPatientsTreatment.Name = "lblPatientsTreatment";
            lblPatientsTreatment.Size = new Size(220, 23);
            lblPatientsTreatment.TabIndex = 10;
            lblPatientsTreatment.Text = "The patients treatment(s)";
            lblPatientsTreatment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxHealth
            // 
            pictureBoxHealth.Image = (Image)resources.GetObject("pictureBoxHealth.Image");
            pictureBoxHealth.Location = new Point(6, 6);
            pictureBoxHealth.Name = "pictureBoxHealth";
            pictureBoxHealth.Size = new Size(67, 54);
            pictureBoxHealth.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHealth.TabIndex = 9;
            pictureBoxHealth.TabStop = false;
            // 
            // dataGridViewTreatment
            // 
            dataGridViewTreatment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTreatment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTreatment.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewTreatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTreatment.Location = new Point(8, 366);
            dataGridViewTreatment.Name = "dataGridViewTreatment";
            dataGridViewTreatment.RowTemplate.Height = 25;
            dataGridViewTreatment.Size = new Size(622, 114);
            dataGridViewTreatment.TabIndex = 8;
            // 
            // btnAssignTreatment
            // 
            btnAssignTreatment.BackColor = Color.MidnightBlue;
            btnAssignTreatment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssignTreatment.ForeColor = SystemColors.ButtonFace;
            btnAssignTreatment.Location = new Point(80, 265);
            btnAssignTreatment.Name = "btnAssignTreatment";
            btnAssignTreatment.Size = new Size(90, 35);
            btnAssignTreatment.TabIndex = 7;
            btnAssignTreatment.Text = "Assign";
            btnAssignTreatment.UseVisualStyleBackColor = false;
            btnAssignTreatment.Click += btnAssignTreatment_Click;
            // 
            // richtxtTreatmentDescription
            // 
            richtxtTreatmentDescription.Location = new Point(80, 158);
            richtxtTreatmentDescription.Name = "richtxtTreatmentDescription";
            richtxtTreatmentDescription.Size = new Size(476, 101);
            richtxtTreatmentDescription.TabIndex = 6;
            richtxtTreatmentDescription.Text = "";
            // 
            // txtAdmissionId
            // 
            txtAdmissionId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAdmissionId.Location = new Point(209, 77);
            txtAdmissionId.MaxLength = 32;
            txtAdmissionId.Name = "txtAdmissionId";
            txtAdmissionId.Size = new Size(219, 23);
            txtAdmissionId.TabIndex = 5;
            // 
            // lblTreatmentDescription
            // 
            lblTreatmentDescription.AutoSize = true;
            lblTreatmentDescription.BackColor = Color.Transparent;
            lblTreatmentDescription.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTreatmentDescription.ForeColor = SystemColors.ButtonFace;
            lblTreatmentDescription.Location = new Point(80, 135);
            lblTreatmentDescription.Name = "lblTreatmentDescription";
            lblTreatmentDescription.Size = new Size(167, 20);
            lblTreatmentDescription.TabIndex = 3;
            lblTreatmentDescription.Text = "Describe Treatment";
            lblTreatmentDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdmissionId
            // 
            lblAdmissionId.BackColor = Color.Transparent;
            lblAdmissionId.Dock = DockStyle.Top;
            lblAdmissionId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdmissionId.ForeColor = SystemColors.ButtonFace;
            lblAdmissionId.Location = new Point(3, 54);
            lblAdmissionId.Name = "lblAdmissionId";
            lblAdmissionId.Size = new Size(651, 20);
            lblAdmissionId.TabIndex = 2;
            lblAdmissionId.Text = "Admission Id";
            lblAdmissionId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAssignTreatment
            // 
            lblAssignTreatment.BackColor = Color.Transparent;
            lblAssignTreatment.Dock = DockStyle.Top;
            lblAssignTreatment.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssignTreatment.ForeColor = SystemColors.ButtonFace;
            lblAssignTreatment.Location = new Point(3, 3);
            lblAssignTreatment.Name = "lblAssignTreatment";
            lblAssignTreatment.Size = new Size(651, 51);
            lblAssignTreatment.TabIndex = 0;
            lblAssignTreatment.Text = "Assign Treatment";
            lblAssignTreatment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabAddPatientNotes
            // 
            tabAddPatientNotes.BackColor = Color.DarkSlateGray;
            tabAddPatientNotes.Controls.Add(txtPatientNumber);
            tabAddPatientNotes.Controls.Add(lblPatientNumber);
            tabAddPatientNotes.Controls.Add(lblSubheadingNotes);
            tabAddPatientNotes.Controls.Add(dataGridViewNotes);
            tabAddPatientNotes.Controls.Add(btnAdd);
            tabAddPatientNotes.Controls.Add(richTxtBoxNotes);
            tabAddPatientNotes.Controls.Add(lblNotes);
            tabAddPatientNotes.Controls.Add(lblTitleNote);
            tabAddPatientNotes.Controls.Add(pictureBoxNotes);
            tabAddPatientNotes.Location = new Point(4, 24);
            tabAddPatientNotes.Name = "tabAddPatientNotes";
            tabAddPatientNotes.Padding = new Padding(3);
            tabAddPatientNotes.Size = new Size(657, 488);
            tabAddPatientNotes.TabIndex = 2;
            tabAddPatientNotes.Text = "Add Patient Notes";
            // 
            // txtPatientNumber
            // 
            txtPatientNumber.Location = new Point(234, 95);
            txtPatientNumber.MaxLength = 20;
            txtPatientNumber.Name = "txtPatientNumber";
            txtPatientNumber.Size = new Size(132, 23);
            txtPatientNumber.TabIndex = 18;
            // 
            // lblPatientNumber
            // 
            lblPatientNumber.AutoSize = true;
            lblPatientNumber.BackColor = Color.Transparent;
            lblPatientNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientNumber.ForeColor = SystemColors.ButtonFace;
            lblPatientNumber.Location = new Point(91, 98);
            lblPatientNumber.Name = "lblPatientNumber";
            lblPatientNumber.Size = new Size(133, 20);
            lblPatientNumber.TabIndex = 17;
            lblPatientNumber.Text = "Patient Number";
            lblPatientNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubheadingNotes
            // 
            lblSubheadingNotes.AutoSize = true;
            lblSubheadingNotes.BackColor = Color.Transparent;
            lblSubheadingNotes.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubheadingNotes.ForeColor = SystemColors.ActiveCaption;
            lblSubheadingNotes.Location = new Point(8, 374);
            lblSubheadingNotes.Name = "lblSubheadingNotes";
            lblSubheadingNotes.Size = new Size(167, 23);
            lblSubheadingNotes.TabIndex = 16;
            lblSubheadingNotes.Text = "This Patients Notes";
            lblSubheadingNotes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewNotes
            // 
            dataGridViewNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewNotes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewNotes.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotes.Location = new Point(8, 400);
            dataGridViewNotes.Name = "dataGridViewNotes";
            dataGridViewNotes.RowTemplate.Height = 25;
            dataGridViewNotes.Size = new Size(646, 86);
            dataGridViewNotes.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(276, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 35);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // richTxtBoxNotes
            // 
            richTxtBoxNotes.Location = new Point(37, 188);
            richTxtBoxNotes.Name = "richTxtBoxNotes";
            richTxtBoxNotes.Size = new Size(329, 132);
            richTxtBoxNotes.TabIndex = 11;
            richTxtBoxNotes.Text = "";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.BackColor = Color.Transparent;
            lblNotes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.ForeColor = SystemColors.ButtonFace;
            lblNotes.Location = new Point(37, 165);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(56, 20);
            lblNotes.TabIndex = 9;
            lblNotes.Text = "Notes";
            lblNotes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitleNote
            // 
            lblTitleNote.BackColor = Color.Transparent;
            lblTitleNote.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleNote.ForeColor = SystemColors.ButtonFace;
            lblTitleNote.Location = new Point(87, 33);
            lblTitleNote.Name = "lblTitleNote";
            lblTitleNote.Size = new Size(205, 26);
            lblTitleNote.TabIndex = 1;
            lblTitleNote.Text = "Add Patient Notes";
            lblTitleNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxNotes
            // 
            pictureBoxNotes.ErrorImage = null;
            pictureBoxNotes.Image = Properties.Resources.patientNotes;
            pictureBoxNotes.InitialImage = null;
            pictureBoxNotes.Location = new Point(6, 6);
            pictureBoxNotes.Name = "pictureBoxNotes";
            pictureBoxNotes.Size = new Size(75, 81);
            pictureBoxNotes.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNotes.TabIndex = 0;
            pictureBoxNotes.TabStop = false;
            // 
            // PhysicianPatientDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 516);
            Controls.Add(tabsPhysicianPatient);
            MinimumSize = new Size(662, 555);
            Name = "PhysicianPatientDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Physician-Patient Dashboard";
            tabsPhysicianPatient.ResumeLayout(false);
            tabViewPatientDetails.ResumeLayout(false);
            tabViewPatientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatientDetails).EndInit();
            tabAssignTreatments.ResumeLayout(false);
            tabAssignTreatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHealth).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).EndInit();
            tabAddPatientNotes.ResumeLayout(false);
            tabAddPatientNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNotes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabsPhysicianPatient;
        private TabPage tabViewPatientDetails;
        private TabPage tabAssignTreatments;
        private TabPage tabAddPatientNotes;
        private DataGridView dataGridViewPatientDetails;
        private Label lblAssignTreatment;
        private Label lblTreatmentDescription;
        private Label lblAdmissionId;
        private RichTextBox richtxtTreatmentDescription;
        private TextBox txtAdmissionId;
        private Button btnAssignTreatment;
        private DataGridView dataGridViewTreatment;
        private PictureBox pictureBoxHealth;
        private Label lblPatientsTreatment;
        private PictureBox pictureBoxNotes;
        private Label lblTitleNote;
        private Label lblSubheadingNotes;
        private DataGridView dataGridViewNotes;
        private TextBox txtPatientName;
        private Button btnAdd;
        private RichTextBox richTxtBoxNotes;
        private Label lblNotes;
        private Label lblPatientName;
        private TextBox txtPatientNumber;
        private Label lblPatientNumber;
        private Button btnPrint;
        private TextBox txtPhysicianNumber;
        private Label lblPhysicianNumber;
        private Label lblPatientDetsTitle;
        private Button btnView;
    }
}