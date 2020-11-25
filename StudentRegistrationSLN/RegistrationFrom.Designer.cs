namespace StudentRegistrationSLN
{
    partial class RegistrationFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.totalProgramGridView = new System.Windows.Forms.DataGridView();
            this.weeklyGridView = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.weeklyEnrollmentReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSortDateDesc = new System.Windows.Forms.Button();
            this.sortNameDesc = new System.Windows.Forms.Button();
            this.sortNameAsc = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProgramEnroll = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.sortDateDesc = new System.Windows.Forms.Button();
            this.sortDateAsc = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalProgramGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyEnrollmentReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(717, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Location = new System.Drawing.Point(308, 9);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1676, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.studentGridView.Location = new System.Drawing.Point(40, 557);
            this.studentGridView.Margin = new System.Windows.Forms.Padding(4);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowHeadersWidth = 51;
            this.studentGridView.Size = new System.Drawing.Size(1545, 307);
            this.studentGridView.TabIndex = 20;
            this.studentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelChart);
            this.panel1.Controls.Add(this.btnSortDateDesc);
            this.panel1.Controls.Add(this.sortNameDesc);
            this.panel1.Controls.Add(this.sortNameAsc);
            this.panel1.Controls.Add(this.studentGridView);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dpRegistrationDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbProgramEnroll);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtContactNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dpDateOfBirth);
            this.panel1.Controls.Add(this.sortDateDesc);
            this.panel1.Controls.Add(this.sortDateAsc);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(313, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1598, 868);
            this.panel1.TabIndex = 22;
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.totalProgramGridView);
            this.panelChart.Controls.Add(this.weeklyGridView);
            this.panelChart.Controls.Add(this.btnGenerate);
            this.panelChart.Controls.Add(this.dpStartDate);
            this.panelChart.Controls.Add(this.label9);
            this.panelChart.Controls.Add(this.weeklyEnrollmentReport);
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Margin = new System.Windows.Forms.Padding(4);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1598, 868);
            this.panelChart.TabIndex = 22;
            this.panelChart.Visible = false;
            // 
            // totalProgramGridView
            // 
            this.totalProgramGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalProgramGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalProgramGridView.Location = new System.Drawing.Point(473, 54);
            this.totalProgramGridView.Name = "totalProgramGridView";
            this.totalProgramGridView.RowHeadersWidth = 51;
            this.totalProgramGridView.RowTemplate.Height = 24;
            this.totalProgramGridView.Size = new System.Drawing.Size(338, 152);
            this.totalProgramGridView.TabIndex = 7;
            this.totalProgramGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.totalProgramGridView_CellContentClick);
            // 
            // weeklyGridView
            // 
            this.weeklyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyGridView.Location = new System.Drawing.Point(401, 566);
            this.weeklyGridView.Name = "weeklyGridView";
            this.weeklyGridView.RowHeadersWidth = 51;
            this.weeklyGridView.RowTemplate.Height = 24;
            this.weeklyGridView.Size = new System.Drawing.Size(338, 135);
            this.weeklyGridView.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(786, 621);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(156, 44);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dpStartDate
            // 
            this.dpStartDate.Location = new System.Drawing.Point(401, 493);
            this.dpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(518, 22);
            this.dpStartDate.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 498);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Date:";
            // 
            // weeklyEnrollmentReport
            // 
            this.weeklyEnrollmentReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.weeklyEnrollmentReport.BorderlineWidth = 0;
            this.weeklyEnrollmentReport.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.weeklyEnrollmentReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weeklyEnrollmentReport.Legends.Add(legend1);
            this.weeklyEnrollmentReport.Location = new System.Drawing.Point(901, 22);
            this.weeklyEnrollmentReport.Margin = new System.Windows.Forms.Padding(4);
            this.weeklyEnrollmentReport.Name = "weeklyEnrollmentReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.weeklyEnrollmentReport.Series.Add(series1);
            this.weeklyEnrollmentReport.Size = new System.Drawing.Size(664, 407);
            this.weeklyEnrollmentReport.TabIndex = 0;
            this.weeklyEnrollmentReport.Text = "chart1";
            // 
            // btnSortDateDesc
            // 
            this.btnSortDateDesc.Location = new System.Drawing.Point(1216, 477);
            this.btnSortDateDesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortDateDesc.Name = "btnSortDateDesc";
            this.btnSortDateDesc.Size = new System.Drawing.Size(250, 49);
            this.btnSortDateDesc.TabIndex = 29;
            this.btnSortDateDesc.Text = "Sort Date Desc";
            this.btnSortDateDesc.UseVisualStyleBackColor = true;
            this.btnSortDateDesc.Click += new System.EventHandler(this.btnSortDateDesc_Click);
            // 
            // sortNameDesc
            // 
            this.sortNameDesc.Location = new System.Drawing.Point(374, 477);
            this.sortNameDesc.Margin = new System.Windows.Forms.Padding(4);
            this.sortNameDesc.Name = "sortNameDesc";
            this.sortNameDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sortNameDesc.Size = new System.Drawing.Size(250, 49);
            this.sortNameDesc.TabIndex = 24;
            this.sortNameDesc.Text = "Sort First Name Desc";
            this.sortNameDesc.UseVisualStyleBackColor = true;
            this.sortNameDesc.Click += new System.EventHandler(this.sortNameDesc_Click);
            // 
            // sortNameAsc
            // 
            this.sortNameAsc.Location = new System.Drawing.Point(91, 477);
            this.sortNameAsc.Margin = new System.Windows.Forms.Padding(4);
            this.sortNameAsc.Name = "sortNameAsc";
            this.sortNameAsc.Size = new System.Drawing.Size(250, 49);
            this.sortNameAsc.TabIndex = 23;
            this.sortNameAsc.Text = "Sort First Name Asc";
            this.sortNameAsc.UseVisualStyleBackColor = true;
            this.sortNameAsc.Click += new System.EventHandler(this.sortNameAsc_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(386, 61);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(438, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name: ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(51, 54);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(86, 22);
            this.txtId.TabIndex = 21;
            this.txtId.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1429, 385);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 44);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1251, 385);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 44);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1075, 385);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 44);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dpRegistrationDate
            // 
            this.dpRegistrationDate.Location = new System.Drawing.Point(1095, 291);
            this.dpRegistrationDate.Margin = new System.Windows.Forms.Padding(4);
            this.dpRegistrationDate.Name = "dpRegistrationDate";
            this.dpRegistrationDate.Size = new System.Drawing.Size(464, 22);
            this.dpRegistrationDate.TabIndex = 15;
            this.dpRegistrationDate.Value = new System.DateTime(2019, 12, 29, 21, 42, 2, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(887, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Registration Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Program Enrol:";
            // 
            // cbProgramEnroll
            // 
            this.cbProgramEnroll.FormattingEnabled = true;
            this.cbProgramEnroll.Items.AddRange(new object[] {
            "Computing",
            "Multimedia Technologies",
            "Networks and IT Security"});
            this.cbProgramEnroll.Location = new System.Drawing.Point(386, 295);
            this.cbProgramEnroll.Margin = new System.Windows.Forms.Padding(4);
            this.cbProgramEnroll.Name = "cbProgramEnroll";
            this.cbProgramEnroll.Size = new System.Drawing.Size(371, 24);
            this.cbProgramEnroll.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(386, 216);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(438, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email: ";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(386, 145);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(438, 22);
            this.txtContactNo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact No:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1095, 141);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(438, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(887, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1095, 61);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(438, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(887, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(887, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Date of Birth:";
            // 
            // dpDateOfBirth
            // 
            this.dpDateOfBirth.Location = new System.Drawing.Point(1095, 212);
            this.dpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dpDateOfBirth.Name = "dpDateOfBirth";
            this.dpDateOfBirth.Size = new System.Drawing.Size(438, 22);
            this.dpDateOfBirth.TabIndex = 28;
            this.dpDateOfBirth.Value = new System.DateTime(2019, 12, 29, 21, 42, 2, 0);
            // 
            // sortDateDesc
            // 
            this.sortDateDesc.Location = new System.Drawing.Point(1833, 21);
            this.sortDateDesc.Margin = new System.Windows.Forms.Padding(4);
            this.sortDateDesc.Name = "sortDateDesc";
            this.sortDateDesc.Size = new System.Drawing.Size(250, 49);
            this.sortDateDesc.TabIndex = 26;
            this.sortDateDesc.Text = "Sort Date Desc";
            this.sortDateDesc.UseVisualStyleBackColor = true;
            // 
            // sortDateAsc
            // 
            this.sortDateAsc.Location = new System.Drawing.Point(927, 477);
            this.sortDateAsc.Margin = new System.Windows.Forms.Padding(4);
            this.sortDateAsc.Name = "sortDateAsc";
            this.sortDateAsc.Size = new System.Drawing.Size(250, 49);
            this.sortDateAsc.TabIndex = 25;
            this.sortDateAsc.Text = "Sort Date Asc";
            this.sortDateAsc.UseVisualStyleBackColor = true;
            this.sortDateAsc.Click += new System.EventHandler(this.sortDateAsc_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Enrolled",
            "Processing",
            "Not Enrolled"});
            this.cbStatus.Location = new System.Drawing.Point(386, 362);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(371, 24);
            this.cbStatus.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(142, 362);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Status:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 1535);
            this.panel2.TabIndex = 23;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.DimGray;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(77, 132);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(121, 32);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Reports";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(19, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(243, 32);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register Student";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RegistrationFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrationFrom";
            this.Text = "RegistrationFrom";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChart.ResumeLayout(false);
            this.panelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalProgramGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyEnrollmentReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dpRegistrationDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProgramEnroll;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyEnrollmentReport;
        private System.Windows.Forms.Button sortDateDesc;
        private System.Windows.Forms.Button sortDateAsc;
        private System.Windows.Forms.Button sortNameDesc;
        private System.Windows.Forms.Button sortNameAsc;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dpDateOfBirth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView weeklyGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView totalProgramGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
        private System.Windows.Forms.Button btnSortDateDesc;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}