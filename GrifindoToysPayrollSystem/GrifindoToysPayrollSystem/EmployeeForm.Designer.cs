namespace GrifindoToysPayrollSystem
{
    partial class EmployeeForm
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
            System.Windows.Forms.Button btnSearchEm;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            System.Windows.Forms.Button btnExit;
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbCivilStatus = new System.Windows.Forms.ComboBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.txtOvertimeRate = new System.Windows.Forms.TextBox();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCl = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnSav = new System.Windows.Forms.Button();
            btnSearchEm = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchEm
            // 
            btnSearchEm.BackColor = System.Drawing.Color.Transparent;
            btnSearchEm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchEm.BackgroundImage")));
            btnSearchEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSearchEm.FlatAppearance.BorderSize = 0;
            btnSearchEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearchEm.Location = new System.Drawing.Point(347, 52);
            btnSearchEm.Name = "btnSearchEm";
            btnSearchEm.Size = new System.Drawing.Size(39, 39);
            btnSearchEm.TabIndex = 82;
            btnSearchEm.UseVisualStyleBackColor = false;
            btnSearchEm.Click += new System.EventHandler(this.btnSearchEm_Click);
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Location = new System.Drawing.Point(720, 16);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(31, 29);
            btnExit.TabIndex = 90;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += new System.EventHandler(this.btnExit_Click_2);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmployeeID.Location = new System.Drawing.Point(184, 63);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 24);
            this.lblEmployeeID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(27, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "NIC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(27, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(27, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(27, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(27, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Monthly Salary";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(392, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Civil Status";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(186, 105);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(565, 32);
            this.txtEmployeeName.TabIndex = 10;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(186, 148);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(565, 32);
            this.txtNIC.TabIndex = 11;
            this.txtNIC.TextChanged += new System.EventHandler(this.txtNIC_TextChanged_1);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(186, 191);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(565, 32);
            this.txtContactNumber.TabIndex = 12;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged_1);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(186, 236);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(565, 32);
            this.txtAddress.TabIndex = 13;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(186, 289);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 32);
            this.dtpDateOfBirth.TabIndex = 14;
            // 
            // cmbCivilStatus
            // 
            this.cmbCivilStatus.FormattingEnabled = true;
            this.cmbCivilStatus.Items.AddRange(new object[] {
            "-Select Your Civil Status-",
            "Married",
            "Unmarried"});
            this.cmbCivilStatus.Location = new System.Drawing.Point(547, 289);
            this.cmbCivilStatus.Name = "cmbCivilStatus";
            this.cmbCivilStatus.Size = new System.Drawing.Size(204, 32);
            this.cmbCivilStatus.TabIndex = 15;
            this.cmbCivilStatus.Text = "Select Your Civil Status";
            this.cmbCivilStatus.SelectedIndexChanged += new System.EventHandler(this.cmbCivilStatus_SelectedIndexChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(6, 41);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(77, 28);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(151, 41);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(95, 28);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(31, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(27, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Allowance";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(27, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Overtime Rate";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.Location = new System.Drawing.Point(182, 458);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.Size = new System.Drawing.Size(215, 32);
            this.txtMonthlySalary.TabIndex = 21;
            // 
            // txtOvertimeRate
            // 
            this.txtOvertimeRate.Location = new System.Drawing.Point(182, 498);
            this.txtOvertimeRate.Name = "txtOvertimeRate";
            this.txtOvertimeRate.Size = new System.Drawing.Size(215, 32);
            this.txtOvertimeRate.TabIndex = 22;
            // 
            // txtAllowance
            // 
            this.txtAllowance.Location = new System.Drawing.Point(182, 537);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(215, 32);
            this.txtAllowance.TabIndex = 23;
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Items.AddRange(new object[] {
            "-Select Employee ID-"});
            this.cmbEmployeeID.Location = new System.Drawing.Point(186, 56);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(155, 32);
            this.cmbEmployeeID.TabIndex = 28;
            this.cmbEmployeeID.Text = "Select Emp. ID";
            this.cmbEmployeeID.Visible = false;
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(27, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 24);
            this.label11.TabIndex = 53;
            this.label11.Text = "EMPLOYEE DETAILS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 19);
            this.label12.TabIndex = 54;
            this.label12.Text = "(Exclude \"V\")";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.Transparent;
            this.btnDel.Location = new System.Drawing.Point(145, 590);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(39, 40);
            this.btnDel.TabIndex = 86;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCl
            // 
            this.btnCl.BackColor = System.Drawing.Color.Transparent;
            this.btnCl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCl.BackgroundImage")));
            this.btnCl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCl.FlatAppearance.BorderSize = 0;
            this.btnCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCl.ForeColor = System.Drawing.Color.Transparent;
            this.btnCl.Location = new System.Drawing.Point(31, 591);
            this.btnCl.Name = "btnCl";
            this.btnCl.Size = new System.Drawing.Size(39, 39);
            this.btnCl.TabIndex = 87;
            this.btnCl.UseVisualStyleBackColor = false;
            this.btnCl.Click += new System.EventHandler(this.btnCl_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUp.BackgroundImage")));
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnUp.Location = new System.Drawing.Point(252, 590);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(39, 40);
            this.btnUp.TabIndex = 88;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSav
            // 
            this.btnSav.BackColor = System.Drawing.Color.Transparent;
            this.btnSav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSav.BackgroundImage")));
            this.btnSav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSav.FlatAppearance.BorderSize = 0;
            this.btnSav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSav.ForeColor = System.Drawing.Color.Transparent;
            this.btnSav.Location = new System.Drawing.Point(358, 590);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(39, 40);
            this.btnSav.TabIndex = 89;
            this.btnSav.UseVisualStyleBackColor = false;
            this.btnSav.Click += new System.EventHandler(this.btnSav_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 653);
            this.ControlBox = false;
            this.Controls.Add(btnExit);
            this.Controls.Add(this.btnSav);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnCl);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(btnSearchEm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbEmployeeID);
            this.Controls.Add(this.txtAllowance);
            this.Controls.Add(this.txtOvertimeRate);
            this.Controls.Add(this.txtMonthlySalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCivilStatus);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmployeeID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cmbCivilStatus;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMonthlySalary;
        private System.Windows.Forms.TextBox txtOvertimeRate;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCl;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSav;
    }
}