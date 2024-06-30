namespace GrifindoToysPayrollSystem
{
    partial class SalaryForm
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
            System.Windows.Forms.Button btnClose;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryForm));
            System.Windows.Forms.Button btnSalAll;
            System.Windows.Forms.Button btnSalIn;
            System.Windows.Forms.Button btnSalCal;
            System.Windows.Forms.Button btnClear;
            System.Windows.Forms.Button btnSaveSal;
            this.txtNumberOfHolidays = new System.Windows.Forms.TextBox();
            this.txtOvertimeHours = new System.Windows.Forms.TextBox();
            this.txtLeaveCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumberOfAbsentDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBasePay = new System.Windows.Forms.Label();
            this.lblNoPay = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOverrunLeaves = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAvailableLeaves = new System.Windows.Forms.TextBox();
            this.txtLeavesPerYear = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnSalAll = new System.Windows.Forms.Button();
            btnSalIn = new System.Windows.Forms.Button();
            btnSalCal = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnSaveSal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Location = new System.Drawing.Point(771, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(31, 29);
            btnClose.TabIndex = 78;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSalAll
            // 
            btnSalAll.BackColor = System.Drawing.Color.Transparent;
            btnSalAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalAll.BackgroundImage")));
            btnSalAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSalAll.FlatAppearance.BorderSize = 0;
            btnSalAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalAll.Location = new System.Drawing.Point(115, 41);
            btnSalAll.Name = "btnSalAll";
            btnSalAll.Size = new System.Drawing.Size(39, 39);
            btnSalAll.TabIndex = 79;
            btnSalAll.UseVisualStyleBackColor = false;
            btnSalAll.Click += new System.EventHandler(this.btnSalaryIn_Click);
            // 
            // btnSalIn
            // 
            btnSalIn.BackColor = System.Drawing.Color.Transparent;
            btnSalIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalIn.BackgroundImage")));
            btnSalIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSalIn.FlatAppearance.BorderSize = 0;
            btnSalIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalIn.Location = new System.Drawing.Point(23, 41);
            btnSalIn.Name = "btnSalIn";
            btnSalIn.Size = new System.Drawing.Size(39, 39);
            btnSalIn.TabIndex = 80;
            btnSalIn.UseVisualStyleBackColor = false;
            btnSalIn.Click += new System.EventHandler(this.btnSalIn_Click);
            // 
            // btnSalCal
            // 
            btnSalCal.BackColor = System.Drawing.Color.Transparent;
            btnSalCal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalCal.BackgroundImage")));
            btnSalCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSalCal.FlatAppearance.BorderSize = 0;
            btnSalCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalCal.Location = new System.Drawing.Point(431, 328);
            btnSalCal.Name = "btnSalCal";
            btnSalCal.Size = new System.Drawing.Size(39, 39);
            btnSalCal.TabIndex = 81;
            btnSalCal.UseVisualStyleBackColor = false;
            btnSalCal.Click += new System.EventHandler(this.btnSalCal_Click);
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.Transparent;
            btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Location = new System.Drawing.Point(318, 569);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(39, 39);
            btnClear.TabIndex = 83;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveSal
            // 
            btnSaveSal.BackColor = System.Drawing.Color.Transparent;
            btnSaveSal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveSal.BackgroundImage")));
            btnSaveSal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSaveSal.FlatAppearance.BorderSize = 0;
            btnSaveSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveSal.Location = new System.Drawing.Point(431, 569);
            btnSaveSal.Name = "btnSaveSal";
            btnSaveSal.Size = new System.Drawing.Size(39, 39);
            btnSaveSal.TabIndex = 84;
            btnSaveSal.UseVisualStyleBackColor = false;
            btnSaveSal.Click += new System.EventHandler(this.btnSaveSal_Click);
            // 
            // txtNumberOfHolidays
            // 
            this.txtNumberOfHolidays.Location = new System.Drawing.Point(244, 245);
            this.txtNumberOfHolidays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberOfHolidays.Name = "txtNumberOfHolidays";
            this.txtNumberOfHolidays.Size = new System.Drawing.Size(226, 32);
            this.txtNumberOfHolidays.TabIndex = 50;
            this.txtNumberOfHolidays.TextChanged += new System.EventHandler(this.txtAllowance_TextChanged);
            // 
            // txtOvertimeHours
            // 
            this.txtOvertimeHours.Location = new System.Drawing.Point(244, 285);
            this.txtOvertimeHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOvertimeHours.Name = "txtOvertimeHours";
            this.txtOvertimeHours.Size = new System.Drawing.Size(226, 32);
            this.txtOvertimeHours.TabIndex = 49;
            this.txtOvertimeHours.TextChanged += new System.EventHandler(this.txtOvertimeRate_TextChanged);
            // 
            // txtLeaveCount
            // 
            this.txtLeaveCount.Location = new System.Drawing.Point(212, 77);
            this.txtLeaveCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLeaveCount.Name = "txtLeaveCount";
            this.txtLeaveCount.Size = new System.Drawing.Size(89, 32);
            this.txtLeaveCount.TabIndex = 48;
            this.txtLeaveCount.TextChanged += new System.EventHandler(this.txtMonthlySalary_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(13, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 24);
            this.label10.TabIndex = 47;
            this.label10.Text = "Overtime Work Hours";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(13, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Number of Holidays";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Items.AddRange(new object[] {
            "-Select ID-"});
            this.cmbEmployeeID.Location = new System.Drawing.Point(244, 52);
            this.cmbEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(166, 32);
            this.cmbEmployeeID.TabIndex = 55;
            this.cmbEmployeeID.Text = "Select ID";
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(244, 163);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(226, 32);
            this.dtpEndDate.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(13, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Begin Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Employee ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmployeeName.Location = new System.Drawing.Point(240, 95);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 24);
            this.lblEmployeeName.TabIndex = 56;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(244, 123);
            this.dtpBeginDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(226, 32);
            this.dtpBeginDate.TabIndex = 58;
            this.dtpBeginDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtNumberOfAbsentDays
            // 
            this.txtNumberOfAbsentDays.Location = new System.Drawing.Point(244, 205);
            this.txtNumberOfAbsentDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberOfAbsentDays.Name = "txtNumberOfAbsentDays";
            this.txtNumberOfAbsentDays.Size = new System.Drawing.Size(226, 32);
            this.txtNumberOfAbsentDays.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(13, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "Number of Absent days";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(12, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 66;
            this.label9.Text = "Base Pay";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(12, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 63;
            this.label11.Text = "Gross Pay";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(12, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 24);
            this.label12.TabIndex = 62;
            this.label12.Text = "No Pay";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(btnSalIn);
            this.groupBox1.Controls.Add(btnSalAll);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(488, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 114);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary Reports";
            // 
            // lblBasePay
            // 
            this.lblBasePay.AutoSize = true;
            this.lblBasePay.BackColor = System.Drawing.Color.Transparent;
            this.lblBasePay.Location = new System.Drawing.Point(239, 416);
            this.lblBasePay.Name = "lblBasePay";
            this.lblBasePay.Size = new System.Drawing.Size(0, 24);
            this.lblBasePay.TabIndex = 73;
            // 
            // lblNoPay
            // 
            this.lblNoPay.AutoSize = true;
            this.lblNoPay.BackColor = System.Drawing.Color.Transparent;
            this.lblNoPay.Location = new System.Drawing.Point(239, 465);
            this.lblNoPay.Name = "lblNoPay";
            this.lblNoPay.Size = new System.Drawing.Size(0, 24);
            this.lblNoPay.TabIndex = 74;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.BackColor = System.Drawing.Color.Transparent;
            this.lblGrossPay.Location = new System.Drawing.Point(239, 515);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(0, 24);
            this.lblGrossPay.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "SALARY DETAILS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtOverrunLeaves);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtAvailableLeaves);
            this.groupBox2.Controls.Add(this.txtLeavesPerYear);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtLeaveCount);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(488, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 239);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leaves Summary";
            // 
            // txtOverrunLeaves
            // 
            this.txtOverrunLeaves.Location = new System.Drawing.Point(212, 157);
            this.txtOverrunLeaves.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOverrunLeaves.Name = "txtOverrunLeaves";
            this.txtOverrunLeaves.Size = new System.Drawing.Size(89, 32);
            this.txtOverrunLeaves.TabIndex = 85;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(6, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 24);
            this.label16.TabIndex = 84;
            this.label16.Text = "Over Run Leaves";
            // 
            // txtAvailableLeaves
            // 
            this.txtAvailableLeaves.Location = new System.Drawing.Point(212, 117);
            this.txtAvailableLeaves.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAvailableLeaves.Name = "txtAvailableLeaves";
            this.txtAvailableLeaves.Size = new System.Drawing.Size(89, 32);
            this.txtAvailableLeaves.TabIndex = 83;
            this.txtAvailableLeaves.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLeavesPerYear
            // 
            this.txtLeavesPerYear.Location = new System.Drawing.Point(212, 37);
            this.txtLeavesPerYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLeavesPerYear.Name = "txtLeavesPerYear";
            this.txtLeavesPerYear.Size = new System.Drawing.Size(89, 32);
            this.txtLeavesPerYear.TabIndex = 82;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(6, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 24);
            this.label15.TabIndex = 81;
            this.label15.Text = "Available Leaves";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(6, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 24);
            this.label14.TabIndex = 80;
            this.label14.Text = "Leaves";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(6, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 24);
            this.label13.TabIndex = 79;
            this.label13.Text = "Leaves Per Year";
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 630);
            this.ControlBox = false;
            this.Controls.Add(btnSaveSal);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnSalCal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblNoPay);
            this.Controls.Add(this.lblBasePay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNumberOfAbsentDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txtNumberOfHolidays);
            this.Controls.Add(this.txtOvertimeHours);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEmployeeID);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumberOfHolidays;
        private System.Windows.Forms.TextBox txtOvertimeHours;
        private System.Windows.Forms.TextBox txtLeaveCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.TextBox txtNumberOfAbsentDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBasePay;
        private System.Windows.Forms.Label lblNoPay;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOverrunLeaves;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAvailableLeaves;
        private System.Windows.Forms.TextBox txtLeavesPerYear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}