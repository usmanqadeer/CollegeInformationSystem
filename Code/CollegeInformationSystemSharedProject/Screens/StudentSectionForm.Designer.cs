namespace CollegeInformationSystem
{
    partial class SetSectionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtSectionRemarks = new System.Windows.Forms.TextBox();
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.lblSectionRemarks = new System.Windows.Forms.Label();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.StudentSectionDataGridView = new System.Windows.Forms.DataGridView();
            this.lblSessionName = new System.Windows.Forms.Label();
            this.cmbStudentSession = new System.Windows.Forms.ComboBox();
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnMinimized = new Guna.UI.WinForms.GunaControlBox();
            this.btnClosed = new Guna.UI.WinForms.GunaControlBox();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnShowReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentSectionDataGridView)).BeginInit();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.chkIsEnabled.Enabled = false;
            this.chkIsEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkIsEnabled.Location = new System.Drawing.Point(143, 189);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(85, 24);
            this.chkIsEnabled.TabIndex = 25;
            this.chkIsEnabled.Text = "Enabled";
            this.chkIsEnabled.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(488, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 37);
            this.btnDelete.TabIndex = 24;
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
            this.btnSave.Location = new System.Drawing.Point(374, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 23;
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
            this.btnEdit.Location = new System.Drawing.Point(252, 264);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 37);
            this.btnEdit.TabIndex = 22;
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
            this.btnAdd.Location = new System.Drawing.Point(143, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 37);
            this.btnAdd.TabIndex = 21;
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
            this.btnLast.Location = new System.Drawing.Point(488, 221);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(85, 37);
            this.btnLast.TabIndex = 20;
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
            this.btnNext.Location = new System.Drawing.Point(374, 221);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 37);
            this.btnNext.TabIndex = 19;
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
            this.btnPrevious.Location = new System.Drawing.Point(252, 221);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 37);
            this.btnPrevious.TabIndex = 18;
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
            this.btnFirst.Location = new System.Drawing.Point(143, 221);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(85, 37);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtSectionRemarks
            // 
            this.txtSectionRemarks.Location = new System.Drawing.Point(143, 134);
            this.txtSectionRemarks.Multiline = true;
            this.txtSectionRemarks.Name = "txtSectionRemarks";
            this.txtSectionRemarks.ReadOnly = true;
            this.txtSectionRemarks.Size = new System.Drawing.Size(430, 48);
            this.txtSectionRemarks.TabIndex = 16;
            this.txtSectionRemarks.Tag = "";
            // 
            // txtSectionName
            // 
            this.txtSectionName.Location = new System.Drawing.Point(143, 102);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.ReadOnly = true;
            this.txtSectionName.Size = new System.Drawing.Size(430, 26);
            this.txtSectionName.TabIndex = 15;
            this.txtSectionName.Tag = "0";
            // 
            // lblSectionRemarks
            // 
            this.lblSectionRemarks.AutoSize = true;
            this.lblSectionRemarks.Location = new System.Drawing.Point(9, 139);
            this.lblSectionRemarks.Name = "lblSectionRemarks";
            this.lblSectionRemarks.Size = new System.Drawing.Size(128, 20);
            this.lblSectionRemarks.TabIndex = 14;
            this.lblSectionRemarks.Text = "Section Remarks";
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Location = new System.Drawing.Point(10, 105);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(115, 20);
            this.lblSectionName.TabIndex = 13;
            this.lblSectionName.Text = "Section  Name";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(541, 191);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(32, 20);
            this.lblRecord.TabIndex = 64;
            this.lblRecord.Text = "1/1";
            // 
            // StudentSectionDataGridView
            // 
            this.StudentSectionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StudentSectionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentSectionDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.StudentSectionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentSectionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentSectionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentSectionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentSectionDataGridView.ColumnHeadersHeight = 30;
            this.StudentSectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudentSectionDataGridView.EnableHeadersVisualStyles = false;
            this.StudentSectionDataGridView.GridColor = System.Drawing.Color.SteelBlue;
            this.StudentSectionDataGridView.Location = new System.Drawing.Point(13, 307);
            this.StudentSectionDataGridView.Name = "StudentSectionDataGridView";
            this.StudentSectionDataGridView.ReadOnly = true;
            this.StudentSectionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentSectionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.StudentSectionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentSectionDataGridView.Size = new System.Drawing.Size(589, 115);
            this.StudentSectionDataGridView.TabIndex = 79;
            // 
            // lblSessionName
            // 
            this.lblSessionName.AutoSize = true;
            this.lblSessionName.Location = new System.Drawing.Point(9, 70);
            this.lblSessionName.Name = "lblSessionName";
            this.lblSessionName.Size = new System.Drawing.Size(108, 20);
            this.lblSessionName.TabIndex = 80;
            this.lblSessionName.Text = "Session Name";
            // 
            // cmbStudentSession
            // 
            this.cmbStudentSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentSession.FormattingEnabled = true;
            this.cmbStudentSession.Location = new System.Drawing.Point(143, 67);
            this.cmbStudentSession.Name = "cmbStudentSession";
            this.cmbStudentSession.Size = new System.Drawing.Size(430, 28);
            this.cmbStudentSession.TabIndex = 81;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panHeader.Controls.Add(this.btnMinimized);
            this.panHeader.Controls.Add(this.btnClosed);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(613, 46);
            this.panHeader.TabIndex = 82;
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
            this.btnMinimized.Location = new System.Drawing.Point(546, 3);
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
            this.btnClosed.Location = new System.Drawing.Point(572, 4);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnClosed.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClosed.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnClosed.Size = new System.Drawing.Size(30, 39);
            this.btnClosed.TabIndex = 0;
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.panHeader;
            this.dragControl.Vertical = true;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(28, 252);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(75, 33);
            this.btnShowReport.TabIndex = 83;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // SetSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(613, 448);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.cmbStudentSession);
            this.Controls.Add(this.lblSessionName);
            this.Controls.Add(this.StudentSectionDataGridView);
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
            this.Controls.Add(this.txtSectionRemarks);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.lblSectionRemarks);
            this.Controls.Add(this.lblSectionName);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SetSectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetSectionForm";
            this.Load += new System.EventHandler(this.SetSectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentSectionDataGridView)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIsEnabled;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtSectionRemarks;
        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.Label lblSectionRemarks;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.DataGridView StudentSectionDataGridView;
        private System.Windows.Forms.Label lblSessionName;
        private System.Windows.Forms.ComboBox cmbStudentSession;
        private System.Windows.Forms.Panel panHeader;
        private Guna.UI.WinForms.GunaControlBox btnMinimized;
        private Guna.UI.WinForms.GunaControlBox btnClosed;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.Button btnShowReport;
    }
}