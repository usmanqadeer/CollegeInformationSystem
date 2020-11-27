namespace CollegeInformationSystem
{
    partial class AddToBlackListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToBlackListForm));
            this.txtBlackListRemarks = new System.Windows.Forms.TextBox();
            this.lblBlackListRemarks = new System.Windows.Forms.Label();
            this.txtBlackListStudentCNIC = new System.Windows.Forms.TextBox();
            this.txtBlackListStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentCNIC = new System.Windows.Forms.Label();
            this.lblSlectDegree = new System.Windows.Forms.Label();
            this.cmbStudentDegree = new System.Windows.Forms.ComboBox();
            this.lblBlackListName = new System.Windows.Forms.Label();
            this.btnStudentView = new System.Windows.Forms.Button();
            this.btnStudentBlackListDelete = new System.Windows.Forms.Button();
            this.btnStudentEditFromBlackList = new System.Windows.Forms.Button();
            this.btnStudentSaveBlackList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBlackListRemarks
            // 
            this.txtBlackListRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBlackListRemarks.Location = new System.Drawing.Point(361, 247);
            this.txtBlackListRemarks.Multiline = true;
            this.txtBlackListRemarks.Name = "txtBlackListRemarks";
            this.txtBlackListRemarks.Size = new System.Drawing.Size(394, 113);
            this.txtBlackListRemarks.TabIndex = 23;
            // 
            // lblBlackListRemarks
            // 
            this.lblBlackListRemarks.AutoSize = true;
            this.lblBlackListRemarks.Location = new System.Drawing.Point(278, 250);
            this.lblBlackListRemarks.Name = "lblBlackListRemarks";
            this.lblBlackListRemarks.Size = new System.Drawing.Size(70, 20);
            this.lblBlackListRemarks.TabIndex = 22;
            this.lblBlackListRemarks.Text = "Remarks";
            // 
            // txtBlackListStudentCNIC
            // 
            this.txtBlackListStudentCNIC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBlackListStudentCNIC.Location = new System.Drawing.Point(361, 201);
            this.txtBlackListStudentCNIC.Name = "txtBlackListStudentCNIC";
            this.txtBlackListStudentCNIC.Size = new System.Drawing.Size(394, 26);
            this.txtBlackListStudentCNIC.TabIndex = 21;
            // 
            // txtBlackListStudentName
            // 
            this.txtBlackListStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBlackListStudentName.Location = new System.Drawing.Point(361, 155);
            this.txtBlackListStudentName.Name = "txtBlackListStudentName";
            this.txtBlackListStudentName.Size = new System.Drawing.Size(394, 26);
            this.txtBlackListStudentName.TabIndex = 20;
            // 
            // lblStudentCNIC
            // 
            this.lblStudentCNIC.AutoSize = true;
            this.lblStudentCNIC.Location = new System.Drawing.Point(240, 204);
            this.lblStudentCNIC.Name = "lblStudentCNIC";
            this.lblStudentCNIC.Size = new System.Drawing.Size(108, 20);
            this.lblStudentCNIC.TabIndex = 19;
            this.lblStudentCNIC.Text = "Student CNIC";
            // 
            // lblSlectDegree
            // 
            this.lblSlectDegree.AutoSize = true;
            this.lblSlectDegree.Location = new System.Drawing.Point(230, 107);
            this.lblSlectDegree.Name = "lblSlectDegree";
            this.lblSlectDegree.Size = new System.Drawing.Size(118, 20);
            this.lblSlectDegree.TabIndex = 18;
            this.lblSlectDegree.Text = "Select Degree ";
            // 
            // cmbStudentDegree
            // 
            this.cmbStudentDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStudentDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentDegree.FormattingEnabled = true;
            this.cmbStudentDegree.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbStudentDegree.Location = new System.Drawing.Point(361, 107);
            this.cmbStudentDegree.Name = "cmbStudentDegree";
            this.cmbStudentDegree.Size = new System.Drawing.Size(394, 28);
            this.cmbStudentDegree.TabIndex = 24;
            // 
            // lblBlackListName
            // 
            this.lblBlackListName.AutoSize = true;
            this.lblBlackListName.Location = new System.Drawing.Point(236, 158);
            this.lblBlackListName.Name = "lblBlackListName";
            this.lblBlackListName.Size = new System.Drawing.Size(112, 20);
            this.lblBlackListName.TabIndex = 25;
            this.lblBlackListName.Text = "Student Name";
            // 
            // btnStudentView
            // 
            this.btnStudentView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentView.BackColor = System.Drawing.Color.DarkGray;
            this.btnStudentView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentView.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentView.ForeColor = System.Drawing.Color.White;
            this.btnStudentView.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentView.Image")));
            this.btnStudentView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentView.Location = new System.Drawing.Point(861, 177);
            this.btnStudentView.Name = "btnStudentView";
            this.btnStudentView.Size = new System.Drawing.Size(175, 42);
            this.btnStudentView.TabIndex = 63;
            this.btnStudentView.Text = "View";
            this.btnStudentView.UseVisualStyleBackColor = false;
            // 
            // btnStudentBlackListDelete
            // 
            this.btnStudentBlackListDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentBlackListDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnStudentBlackListDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentBlackListDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentBlackListDelete.ForeColor = System.Drawing.Color.White;
            this.btnStudentBlackListDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentBlackListDelete.Image")));
            this.btnStudentBlackListDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentBlackListDelete.Location = new System.Drawing.Point(861, 247);
            this.btnStudentBlackListDelete.Name = "btnStudentBlackListDelete";
            this.btnStudentBlackListDelete.Size = new System.Drawing.Size(175, 42);
            this.btnStudentBlackListDelete.TabIndex = 62;
            this.btnStudentBlackListDelete.Text = "Delete";
            this.btnStudentBlackListDelete.UseVisualStyleBackColor = false;
            // 
            // btnStudentEditFromBlackList
            // 
            this.btnStudentEditFromBlackList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentEditFromBlackList.BackColor = System.Drawing.Color.DarkGray;
            this.btnStudentEditFromBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentEditFromBlackList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentEditFromBlackList.ForeColor = System.Drawing.Color.White;
            this.btnStudentEditFromBlackList.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentEditFromBlackList.Image")));
            this.btnStudentEditFromBlackList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentEditFromBlackList.Location = new System.Drawing.Point(861, 317);
            this.btnStudentEditFromBlackList.Name = "btnStudentEditFromBlackList";
            this.btnStudentEditFromBlackList.Size = new System.Drawing.Size(175, 42);
            this.btnStudentEditFromBlackList.TabIndex = 61;
            this.btnStudentEditFromBlackList.Text = "Edit";
            this.btnStudentEditFromBlackList.UseVisualStyleBackColor = false;
            // 
            // btnStudentSaveBlackList
            // 
            this.btnStudentSaveBlackList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentSaveBlackList.BackColor = System.Drawing.Color.DarkGray;
            this.btnStudentSaveBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentSaveBlackList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentSaveBlackList.ForeColor = System.Drawing.Color.White;
            this.btnStudentSaveBlackList.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentSaveBlackList.Image")));
            this.btnStudentSaveBlackList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentSaveBlackList.Location = new System.Drawing.Point(861, 107);
            this.btnStudentSaveBlackList.Name = "btnStudentSaveBlackList";
            this.btnStudentSaveBlackList.Size = new System.Drawing.Size(175, 42);
            this.btnStudentSaveBlackList.TabIndex = 60;
            this.btnStudentSaveBlackList.Text = "Save";
            this.btnStudentSaveBlackList.UseVisualStyleBackColor = false;
            // 
            // AddToBlackListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1108, 491);
            this.Controls.Add(this.btnStudentView);
            this.Controls.Add(this.btnStudentBlackListDelete);
            this.Controls.Add(this.btnStudentEditFromBlackList);
            this.Controls.Add(this.btnStudentSaveBlackList);
            this.Controls.Add(this.lblBlackListName);
            this.Controls.Add(this.cmbStudentDegree);
            this.Controls.Add(this.txtBlackListRemarks);
            this.Controls.Add(this.lblBlackListRemarks);
            this.Controls.Add(this.txtBlackListStudentCNIC);
            this.Controls.Add(this.txtBlackListStudentName);
            this.Controls.Add(this.lblStudentCNIC);
            this.Controls.Add(this.lblSlectDegree);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddToBlackListForm";
            this.Text = "AddToBlackListForm";
            this.Load += new System.EventHandler(this.AddToBlackListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBlackListRemarks;
        private System.Windows.Forms.Label lblBlackListRemarks;
        private System.Windows.Forms.TextBox txtBlackListStudentCNIC;
        private System.Windows.Forms.TextBox txtBlackListStudentName;
        private System.Windows.Forms.Label lblStudentCNIC;
        private System.Windows.Forms.Label lblSlectDegree;
        private System.Windows.Forms.ComboBox cmbStudentDegree;
        private System.Windows.Forms.Label lblBlackListName;
        private System.Windows.Forms.Button btnStudentView;
        private System.Windows.Forms.Button btnStudentBlackListDelete;
        private System.Windows.Forms.Button btnStudentEditFromBlackList;
        private System.Windows.Forms.Button btnStudentSaveBlackList;
    }
}