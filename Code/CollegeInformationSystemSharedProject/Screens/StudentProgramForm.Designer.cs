namespace CollegeInformationSystem.Screens
{
    partial class StudentProgramForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnMinimized = new Guna.UI.WinForms.GunaControlBox();
            this.btnClosed = new Guna.UI.WinForms.GunaControlBox();
            this.cmbStudentDegree = new System.Windows.Forms.ComboBox();
            this.lblDegreeName = new System.Windows.Forms.Label();
            this.StudentProgramDataGridView = new System.Windows.Forms.DataGridView();
            this.lblRecord = new System.Windows.Forms.Label();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtProgramRemarks = new System.Windows.Forms.TextBox();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.lblProgramRemarks = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentProgramDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panHeader.Controls.Add(this.btnMinimized);
            this.panHeader.Controls.Add(this.btnClosed);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(626, 46);
            this.panHeader.TabIndex = 100;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.AnimationHoverSpeed = 0.07F;
            this.btnMinimized.AnimationSpeed = 0.03F;
            this.btnMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMinimized.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimized.IconColor = System.Drawing.Color.White;
            this.btnMinimized.IconSize = 15F;
            this.btnMinimized.Location = new System.Drawing.Point(559, 3);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMinimized.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimized.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMinimized.Size = new System.Drawing.Size(30, 39);
            this.btnMinimized.TabIndex = 1;
            // 
            // btnClosed
            // 
            this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosed.AnimationHoverSpeed = 0.07F;
            this.btnClosed.AnimationSpeed = 0.03F;
            this.btnClosed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnClosed.IconColor = System.Drawing.Color.White;
            this.btnClosed.IconSize = 15F;
            this.btnClosed.Location = new System.Drawing.Point(585, 4);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnClosed.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClosed.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnClosed.Size = new System.Drawing.Size(30, 39);
            this.btnClosed.TabIndex = 0;
            // 
            // cmbStudentDegree
            // 
            this.cmbStudentDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentDegree.FormattingEnabled = true;
            this.cmbStudentDegree.Location = new System.Drawing.Point(147, 81);
            this.cmbStudentDegree.Name = "cmbStudentDegree";
            this.cmbStudentDegree.Size = new System.Drawing.Size(430, 29);
            this.cmbStudentDegree.TabIndex = 99;
            // 
            // lblDegreeName
            // 
            this.lblDegreeName.AutoSize = true;
            this.lblDegreeName.Location = new System.Drawing.Point(13, 84);
            this.lblDegreeName.Name = "lblDegreeName";
            this.lblDegreeName.Size = new System.Drawing.Size(124, 21);
            this.lblDegreeName.TabIndex = 98;
            this.lblDegreeName.Text = "Degree  Name";
            // 
            // StudentProgramDataGridView
            // 
            this.StudentProgramDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StudentProgramDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentProgramDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.StudentProgramDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentProgramDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentProgramDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentProgramDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StudentProgramDataGridView.ColumnHeadersHeight = 30;
            this.StudentProgramDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudentProgramDataGridView.EnableHeadersVisualStyles = false;
            this.StudentProgramDataGridView.GridColor = System.Drawing.Color.SteelBlue;
            this.StudentProgramDataGridView.Location = new System.Drawing.Point(17, 321);
            this.StudentProgramDataGridView.Name = "StudentProgramDataGridView";
            this.StudentProgramDataGridView.ReadOnly = true;
            this.StudentProgramDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentProgramDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.StudentProgramDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.StudentProgramDataGridView.Size = new System.Drawing.Size(583, 115);
            this.StudentProgramDataGridView.TabIndex = 97;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(545, 205);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(35, 21);
            this.lblRecord.TabIndex = 96;
            this.lblRecord.Text = "1/1";
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.chkIsEnabled.Enabled = false;
            this.chkIsEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkIsEnabled.Location = new System.Drawing.Point(147, 203);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(91, 25);
            this.chkIsEnabled.TabIndex = 95;
            this.chkIsEnabled.Text = "Enabled";
            this.chkIsEnabled.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(492, 278);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 37);
            this.btnDelete.TabIndex = 94;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(378, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(256, 278);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 37);
            this.btnEdit.TabIndex = 92;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(147, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 37);
            this.btnAdd.TabIndex = 91;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(492, 235);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(85, 37);
            this.btnLast.TabIndex = 90;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(378, 235);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 37);
            this.btnNext.TabIndex = 89;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(256, 235);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 37);
            this.btnPrevious.TabIndex = 88;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(147, 235);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(85, 37);
            this.btnFirst.TabIndex = 87;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtProgramRemarks
            // 
            this.txtProgramRemarks.Location = new System.Drawing.Point(147, 148);
            this.txtProgramRemarks.Multiline = true;
            this.txtProgramRemarks.Name = "txtProgramRemarks";
            this.txtProgramRemarks.Size = new System.Drawing.Size(430, 48);
            this.txtProgramRemarks.TabIndex = 86;
            this.txtProgramRemarks.Tag = "";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(147, 116);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(430, 27);
            this.txtProgramName.TabIndex = 85;
            this.txtProgramName.Tag = "0";
            // 
            // lblProgramRemarks
            // 
            this.lblProgramRemarks.AutoSize = true;
            this.lblProgramRemarks.Location = new System.Drawing.Point(12, 151);
            this.lblProgramRemarks.Name = "lblProgramRemarks";
            this.lblProgramRemarks.Size = new System.Drawing.Size(79, 21);
            this.lblProgramRemarks.TabIndex = 84;
            this.lblProgramRemarks.Text = " Remarks";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(14, 119);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(128, 21);
            this.lblProgramName.TabIndex = 83;
            this.lblProgramName.Text = "Program Name";
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.panHeader;
            this.dragControl.Vertical = true;
            // 
            // StudentProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(626, 448);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.cmbStudentDegree);
            this.Controls.Add(this.lblDegreeName);
            this.Controls.Add(this.StudentProgramDataGridView);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.chkIsEnabled);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtProgramRemarks);
            this.Controls.Add(this.txtProgramName);
            this.Controls.Add(this.lblProgramRemarks);
            this.Controls.Add(this.lblProgramName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentProgramForm";
            this.Load += new System.EventHandler(this.StudentProgramForm_Load);
            this.panHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentProgramDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private Guna.UI.WinForms.GunaControlBox btnMinimized;
        private Guna.UI.WinForms.GunaControlBox btnClosed;
        private System.Windows.Forms.ComboBox cmbStudentDegree;
        private System.Windows.Forms.Label lblDegreeName;
        private System.Windows.Forms.DataGridView StudentProgramDataGridView;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.CheckBox chkIsEnabled;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtProgramRemarks;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Label lblProgramRemarks;
        private System.Windows.Forms.Label lblProgramName;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
    }
}