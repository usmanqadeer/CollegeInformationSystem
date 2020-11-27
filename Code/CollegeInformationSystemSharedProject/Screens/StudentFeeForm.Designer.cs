namespace CollegeInformationSystem
{
    partial class StudentFeeForm
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
            this.cmbAnnual = new System.Windows.Forms.ComboBox();
            this.lblAnnual = new System.Windows.Forms.Label();
            this.cmbSelectSemester = new System.Windows.Forms.ComboBox();
            this.lblSelectSemester = new System.Windows.Forms.Label();
            this.cmbEducationSystem = new System.Windows.Forms.ComboBox();
            this.lblEducationSystem = new System.Windows.Forms.Label();
            this.gbStudentFee = new System.Windows.Forms.GroupBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.cmbFeeType = new System.Windows.Forms.ComboBox();
            this.lblFeeType = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cmbStudentGender = new System.Windows.Forms.ComboBox();
            this.dtpFeeSubmitDate = new System.Windows.Forms.DateTimePicker();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.cmbStudentSession = new System.Windows.Forms.ComboBox();
            this.cmbStudentProgram = new System.Windows.Forms.ComboBox();
            this.cmbStudentDegree = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFeeDate = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblSelectSession = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblSelectProgram = new System.Windows.Forms.Label();
            this.lblSelectDegree = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblStudentFee = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFeeoOpration = new System.Windows.Forms.GroupBox();
            this.gbStudentFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAnnual
            // 
            this.cmbAnnual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnnual.FormattingEnabled = true;
            this.cmbAnnual.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year"});
            this.cmbAnnual.Location = new System.Drawing.Point(827, 31);
            this.cmbAnnual.Name = "cmbAnnual";
            this.cmbAnnual.Size = new System.Drawing.Size(233, 28);
            this.cmbAnnual.TabIndex = 93;
            // 
            // lblAnnual
            // 
            this.lblAnnual.AutoSize = true;
            this.lblAnnual.ForeColor = System.Drawing.Color.White;
            this.lblAnnual.Location = new System.Drawing.Point(753, 34);
            this.lblAnnual.Name = "lblAnnual";
            this.lblAnnual.Size = new System.Drawing.Size(68, 20);
            this.lblAnnual.TabIndex = 92;
            this.lblAnnual.Text = " Annual ";
            // 
            // cmbSelectSemester
            // 
            this.cmbSelectSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectSemester.FormattingEnabled = true;
            this.cmbSelectSemester.Items.AddRange(new object[] {
            "Science",
            "Arts",
            "Commerce",
            "DEA"});
            this.cmbSelectSemester.Location = new System.Drawing.Point(514, 31);
            this.cmbSelectSemester.Name = "cmbSelectSemester";
            this.cmbSelectSemester.Size = new System.Drawing.Size(233, 28);
            this.cmbSelectSemester.TabIndex = 91;
            // 
            // lblSelectSemester
            // 
            this.lblSelectSemester.AutoSize = true;
            this.lblSelectSemester.ForeColor = System.Drawing.Color.White;
            this.lblSelectSemester.Location = new System.Drawing.Point(384, 34);
            this.lblSelectSemester.Name = "lblSelectSemester";
            this.lblSelectSemester.Size = new System.Drawing.Size(132, 20);
            this.lblSelectSemester.TabIndex = 90;
            this.lblSelectSemester.Text = "Select Semester  ";
            // 
            // cmbEducationSystem
            // 
            this.cmbEducationSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationSystem.FormattingEnabled = true;
            this.cmbEducationSystem.Items.AddRange(new object[] {
            "Semester System",
            "Annual System"});
            this.cmbEducationSystem.Location = new System.Drawing.Point(149, 31);
            this.cmbEducationSystem.Name = "cmbEducationSystem";
            this.cmbEducationSystem.Size = new System.Drawing.Size(233, 28);
            this.cmbEducationSystem.TabIndex = 89;
            this.cmbEducationSystem.SelectedIndexChanged += new System.EventHandler(this.cmbEducationSystem_SelectedIndexChanged);
            // 
            // lblEducationSystem
            // 
            this.lblEducationSystem.AutoSize = true;
            this.lblEducationSystem.ForeColor = System.Drawing.Color.White;
            this.lblEducationSystem.Location = new System.Drawing.Point(7, 34);
            this.lblEducationSystem.Name = "lblEducationSystem";
            this.lblEducationSystem.Size = new System.Drawing.Size(140, 20);
            this.lblEducationSystem.TabIndex = 88;
            this.lblEducationSystem.Text = " Education System";
            // 
            // gbStudentFee
            // 
            this.gbStudentFee.Controls.Add(this.textBox1);
            this.gbStudentFee.Controls.Add(this.label1);
            this.gbStudentFee.Controls.Add(this.lblStudentFee);
            this.gbStudentFee.Controls.Add(this.txtFee);
            this.gbStudentFee.Controls.Add(this.cmbFeeType);
            this.gbStudentFee.Controls.Add(this.lblFeeType);
            this.gbStudentFee.Controls.Add(this.txtRemarks);
            this.gbStudentFee.Controls.Add(this.lblRemarks);
            this.gbStudentFee.Controls.Add(this.cmbStudentGender);
            this.gbStudentFee.Controls.Add(this.dtpFeeSubmitDate);
            this.gbStudentFee.Controls.Add(this.txtStudentName);
            this.gbStudentFee.Controls.Add(this.txtFatherName);
            this.gbStudentFee.Controls.Add(this.cmbStudentSession);
            this.gbStudentFee.Controls.Add(this.cmbStudentProgram);
            this.gbStudentFee.Controls.Add(this.cmbStudentDegree);
            this.gbStudentFee.Controls.Add(this.lblGender);
            this.gbStudentFee.Controls.Add(this.lblFeeDate);
            this.gbStudentFee.Controls.Add(this.lblFatherName);
            this.gbStudentFee.Controls.Add(this.lblSelectSession);
            this.gbStudentFee.Controls.Add(this.lblStudentName);
            this.gbStudentFee.Controls.Add(this.lblSelectProgram);
            this.gbStudentFee.Controls.Add(this.lblSelectDegree);
            this.gbStudentFee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbStudentFee.Location = new System.Drawing.Point(12, 92);
            this.gbStudentFee.Name = "gbStudentFee";
            this.gbStudentFee.Size = new System.Drawing.Size(750, 384);
            this.gbStudentFee.TabIndex = 94;
            this.gbStudentFee.TabStop = false;
            this.gbStudentFee.Text = "Enter Fee Information";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(502, 209);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(233, 26);
            this.txtFee.TabIndex = 74;
            // 
            // cmbFeeType
            // 
            this.cmbFeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeeType.FormattingEnabled = true;
            this.cmbFeeType.Items.AddRange(new object[] {
            "Science",
            "Arts",
            "Commerce",
            "DEA"});
            this.cmbFeeType.Location = new System.Drawing.Point(502, 155);
            this.cmbFeeType.Name = "cmbFeeType";
            this.cmbFeeType.Size = new System.Drawing.Size(233, 28);
            this.cmbFeeType.TabIndex = 73;
            // 
            // lblFeeType
            // 
            this.lblFeeType.AutoSize = true;
            this.lblFeeType.Location = new System.Drawing.Point(431, 158);
            this.lblFeeType.Name = "lblFeeType";
            this.lblFeeType.Size = new System.Drawing.Size(73, 20);
            this.lblFeeType.TabIndex = 72;
            this.lblFeeType.Text = "Fee Type";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(502, 261);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(233, 65);
            this.txtRemarks.TabIndex = 32;
            // 
            // cmbStudentGender
            // 
            this.cmbStudentGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentGender.FormattingEnabled = true;
            this.cmbStudentGender.Items.AddRange(new object[] {
            "Science",
            "Arts",
            "Commerce",
            "DEA"});
            this.cmbStudentGender.Location = new System.Drawing.Point(127, 249);
            this.cmbStudentGender.Name = "cmbStudentGender";
            this.cmbStudentGender.Size = new System.Drawing.Size(233, 28);
            this.cmbStudentGender.TabIndex = 28;
            // 
            // dtpFeeSubmitDate
            // 
            this.dtpFeeSubmitDate.Location = new System.Drawing.Point(502, 103);
            this.dtpFeeSubmitDate.Name = "dtpFeeSubmitDate";
            this.dtpFeeSubmitDate.Size = new System.Drawing.Size(233, 26);
            this.dtpFeeSubmitDate.TabIndex = 27;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(127, 151);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(233, 26);
            this.txtStudentName.TabIndex = 26;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(127, 200);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(233, 26);
            this.txtFatherName.TabIndex = 25;
            // 
            // cmbStudentSession
            // 
            this.cmbStudentSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentSession.FormattingEnabled = true;
            this.cmbStudentSession.Items.AddRange(new object[] {
            "Science",
            "Arts",
            "Commerce",
            "DEA"});
            this.cmbStudentSession.Location = new System.Drawing.Point(127, 100);
            this.cmbStudentSession.Name = "cmbStudentSession";
            this.cmbStudentSession.Size = new System.Drawing.Size(233, 28);
            this.cmbStudentSession.TabIndex = 24;
            // 
            // cmbStudentProgram
            // 
            this.cmbStudentProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentProgram.FormattingEnabled = true;
            this.cmbStudentProgram.Items.AddRange(new object[] {
            "Science",
            "Arts",
            "Commerce",
            "DEA"});
            this.cmbStudentProgram.Location = new System.Drawing.Point(502, 49);
            this.cmbStudentProgram.Name = "cmbStudentProgram";
            this.cmbStudentProgram.Size = new System.Drawing.Size(233, 28);
            this.cmbStudentProgram.TabIndex = 23;
            // 
            // cmbStudentDegree
            // 
            this.cmbStudentDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentDegree.FormattingEnabled = true;
            this.cmbStudentDegree.Items.AddRange(new object[] {
            "Science",
            "Arts",
            "Commerce",
            "DEA"});
            this.cmbStudentDegree.Location = new System.Drawing.Point(127, 49);
            this.cmbStudentDegree.Name = "cmbStudentDegree";
            this.cmbStudentDegree.Size = new System.Drawing.Size(233, 28);
            this.cmbStudentDegree.TabIndex = 22;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(61, 252);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 20);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblFeeDate
            // 
            this.lblFeeDate.AutoSize = true;
            this.lblFeeDate.Location = new System.Drawing.Point(428, 108);
            this.lblFeeDate.Name = "lblFeeDate";
            this.lblFeeDate.Size = new System.Drawing.Size(76, 20);
            this.lblFeeDate.TabIndex = 5;
            this.lblFeeDate.Text = "Fee Date";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(24, 203);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(103, 20);
            this.lblFatherName.TabIndex = 4;
            this.lblFatherName.Text = "Father Name";
            // 
            // lblSelectSession
            // 
            this.lblSelectSession.AutoSize = true;
            this.lblSelectSession.Location = new System.Drawing.Point(18, 103);
            this.lblSelectSession.Name = "lblSelectSession";
            this.lblSelectSession.Size = new System.Drawing.Size(109, 20);
            this.lblSelectSession.TabIndex = 3;
            this.lblSelectSession.Text = "Select Session";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(15, 154);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(112, 20);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblSelectProgram
            // 
            this.lblSelectProgram.AutoSize = true;
            this.lblSelectProgram.Location = new System.Drawing.Point(384, 52);
            this.lblSelectProgram.Name = "lblSelectProgram";
            this.lblSelectProgram.Size = new System.Drawing.Size(120, 20);
            this.lblSelectProgram.TabIndex = 1;
            this.lblSelectProgram.Text = "Select Program";
            // 
            // lblSelectDegree
            // 
            this.lblSelectDegree.AutoSize = true;
            this.lblSelectDegree.Location = new System.Drawing.Point(13, 52);
            this.lblSelectDegree.Name = "lblSelectDegree";
            this.lblSelectDegree.Size = new System.Drawing.Size(114, 20);
            this.lblSelectDegree.TabIndex = 0;
            this.lblSelectDegree.Text = "Select Degree";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(434, 264);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(70, 20);
            this.lblRemarks.TabIndex = 68;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblStudentFee
            // 
            this.lblStudentFee.AutoSize = true;
            this.lblStudentFee.Location = new System.Drawing.Point(468, 212);
            this.lblStudentFee.Name = "lblStudentFee";
            this.lblStudentFee.Size = new System.Drawing.Size(36, 20);
            this.lblStudentFee.TabIndex = 75;
            this.lblStudentFee.Text = "Fee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 26);
            this.textBox1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Student Name";
            // 
            // gbFeeoOpration
            // 
            this.gbFeeoOpration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFeeoOpration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbFeeoOpration.Location = new System.Drawing.Point(785, 92);
            this.gbFeeoOpration.Name = "gbFeeoOpration";
            this.gbFeeoOpration.Size = new System.Drawing.Size(275, 384);
            this.gbFeeoOpration.TabIndex = 95;
            this.gbFeeoOpration.TabStop = false;
            this.gbFeeoOpration.Text = "Opration";
            // 
            // StudentFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1137, 749);
            this.Controls.Add(this.gbFeeoOpration);
            this.Controls.Add(this.gbStudentFee);
            this.Controls.Add(this.cmbAnnual);
            this.Controls.Add(this.lblAnnual);
            this.Controls.Add(this.cmbSelectSemester);
            this.Controls.Add(this.lblSelectSemester);
            this.Controls.Add(this.cmbEducationSystem);
            this.Controls.Add(this.lblEducationSystem);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentFeeForm";
            this.Text = "StudentFeeForm";
            this.gbStudentFee.ResumeLayout(false);
            this.gbStudentFee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnnual;
        private System.Windows.Forms.Label lblAnnual;
        private System.Windows.Forms.ComboBox cmbSelectSemester;
        private System.Windows.Forms.Label lblSelectSemester;
        private System.Windows.Forms.ComboBox cmbEducationSystem;
        private System.Windows.Forms.Label lblEducationSystem;
        private System.Windows.Forms.GroupBox gbStudentFee;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.ComboBox cmbFeeType;
        private System.Windows.Forms.Label lblFeeType;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cmbStudentGender;
        private System.Windows.Forms.DateTimePicker dtpFeeSubmitDate;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.ComboBox cmbStudentSession;
        private System.Windows.Forms.ComboBox cmbStudentProgram;
        private System.Windows.Forms.ComboBox cmbStudentDegree;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFeeDate;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblSelectSession;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblSelectProgram;
        private System.Windows.Forms.Label lblSelectDegree;
        private System.Windows.Forms.Label lblStudentFee;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFeeoOpration;
    }
}