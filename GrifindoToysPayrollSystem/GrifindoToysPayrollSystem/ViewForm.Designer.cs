namespace GrifindoToysPayrollSystem
{
    partial class ViewLeaves
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
            System.Windows.Forms.Button btnExit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLeaves));
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.dgvLeaveDetails = new System.Windows.Forms.DataGridView();
            this.LeaveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeavingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Location = new System.Drawing.Point(539, 17);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(31, 29);
            btnExit.TabIndex = 130;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmployeeName.Location = new System.Drawing.Point(167, 111);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 24);
            this.lblEmployeeName.TabIndex = 128;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 24);
            this.label11.TabIndex = 125;
            this.label11.Text = "LEAVE DETAILS";
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Items.AddRange(new object[] {
            "-Select Employee ID-"});
            this.cmbEmployeeID.Location = new System.Drawing.Point(171, 59);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(155, 32);
            this.cmbEmployeeID.TabIndex = 124;
            this.cmbEmployeeID.Text = "Select Emp. ID";
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 114;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "Employee ID";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmployeeID.Location = new System.Drawing.Point(169, 66);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 24);
            this.lblEmployeeID.TabIndex = 112;
            // 
            // dgvLeaveDetails
            // 
            this.dgvLeaveDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaveDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLeaveDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveID,
            this.TodayDate,
            this.LeaveDate,
            this.LeavingDays,
            this.Reason});
            this.dgvLeaveDetails.GridColor = System.Drawing.Color.LightGray;
            this.dgvLeaveDetails.Location = new System.Drawing.Point(18, 165);
            this.dgvLeaveDetails.Name = "dgvLeaveDetails";
            this.dgvLeaveDetails.RowTemplate.Height = 28;
            this.dgvLeaveDetails.Size = new System.Drawing.Size(552, 270);
            this.dgvLeaveDetails.TabIndex = 129;
            this.dgvLeaveDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaveDetails_CellContentClick);
            // 
            // LeaveID
            // 
            this.LeaveID.DataPropertyName = "LeaveID";
            this.LeaveID.HeaderText = "Leave ID";
            this.LeaveID.Name = "LeaveID";
            // 
            // TodayDate
            // 
            this.TodayDate.DataPropertyName = "TodayDate";
            this.TodayDate.HeaderText = "Today Date";
            this.TodayDate.Name = "TodayDate";
            // 
            // LeaveDate
            // 
            this.LeaveDate.DataPropertyName = "LeaveDate";
            this.LeaveDate.HeaderText = "Leave Date";
            this.LeaveDate.Name = "LeaveDate";
            // 
            // LeavingDays
            // 
            this.LeavingDays.DataPropertyName = "LeavingDays";
            this.LeavingDays.HeaderText = "Leaving Days";
            this.LeavingDays.Name = "LeavingDays";
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            // 
            // ViewLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(586, 472);
            this.ControlBox = false;
            this.Controls.Add(btnExit);
            this.Controls.Add(this.dgvLeaveDetails);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbEmployeeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmployeeID);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewLeaves";
            this.Text = "ViewLeaves";
            this.Load += new System.EventHandler(this.ViewLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.DataGridView dgvLeaveDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TodayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeavingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
    }
}