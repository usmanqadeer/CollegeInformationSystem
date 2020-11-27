namespace CollegeInformationSystem.InformitionDialod
{
    partial class SuccessMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessMessage));
            this.ElipseSuccessMessageDialog = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuccessMessageDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.picSuccessMessageIcon = new System.Windows.Forms.PictureBox();
            this.lblCommentGrate = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panHoldButton = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnok = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccessMessageIcon)).BeginInit();
            this.panHoldButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseSuccessMessageDialog
            // 
            this.ElipseSuccessMessageDialog.ElipseRadius = 20;
            this.ElipseSuccessMessageDialog.TargetControl = this;
            // 
            // SuccessMessageDragControl
            // 
            this.SuccessMessageDragControl.Fixed = true;
            this.SuccessMessageDragControl.Horizontal = true;
            this.SuccessMessageDragControl.TargetControl = this.picSuccessMessageIcon;
            this.SuccessMessageDragControl.Vertical = true;
            // 
            // picSuccessMessageIcon
            // 
            this.picSuccessMessageIcon.Image = ((System.Drawing.Image)(resources.GetObject("picSuccessMessageIcon.Image")));
            this.picSuccessMessageIcon.Location = new System.Drawing.Point(-3, -15);
            this.picSuccessMessageIcon.Name = "picSuccessMessageIcon";
            this.picSuccessMessageIcon.Size = new System.Drawing.Size(348, 253);
            this.picSuccessMessageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSuccessMessageIcon.TabIndex = 1;
            this.picSuccessMessageIcon.TabStop = false;
            // 
            // lblCommentGrate
            // 
            this.lblCommentGrate.AutoSize = true;
            this.lblCommentGrate.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentGrate.Location = new System.Drawing.Point(143, 124);
            this.lblCommentGrate.Name = "lblCommentGrate";
            this.lblCommentGrate.Size = new System.Drawing.Size(72, 30);
            this.lblCommentGrate.TabIndex = 2;
            this.lblCommentGrate.Text = "Great!";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(56, 150);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(253, 25);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Your opration successfuly complete\r\n";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.UseCompatibleTextRendering = true;
            // 
            // panHoldButton
            // 
            this.panHoldButton.Controls.Add(this.btnCancel);
            this.panHoldButton.Controls.Add(this.btnok);
            this.panHoldButton.Location = new System.Drawing.Point(60, 173);
            this.panHoldButton.Name = "panHoldButton";
            this.panHoldButton.Size = new System.Drawing.Size(230, 50);
            this.panHoldButton.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(5)))), ((int)(((byte)(118)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(5)))), ((int)(((byte)(118)))));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(5)))), ((int)(((byte)(118)))));
            this.btnCancel.IdleForecolor = System.Drawing.Color.White;
            this.btnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnCancel.Location = new System.Drawing.Point(22, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnok
            // 
            this.btnok.ActiveBorderThickness = 1;
            this.btnok.ActiveCornerRadius = 20;
            this.btnok.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(199)))), ((int)(((byte)(156)))));
            this.btnok.ActiveForecolor = System.Drawing.Color.White;
            this.btnok.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(199)))), ((int)(((byte)(156)))));
            this.btnok.BackColor = System.Drawing.Color.White;
            this.btnok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnok.BackgroundImage")));
            this.btnok.ButtonText = "ok";
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.IdleBorderThickness = 1;
            this.btnok.IdleCornerRadius = 20;
            this.btnok.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(199)))), ((int)(((byte)(156)))));
            this.btnok.IdleForecolor = System.Drawing.Color.White;
            this.btnok.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(112)))), ((int)(((byte)(24)))));
            this.btnok.Location = new System.Drawing.Point(118, 5);
            this.btnok.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(84, 45);
            this.btnok.TabIndex = 1;
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // SuccessMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 235);
            this.Controls.Add(this.panHoldButton);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblCommentGrate);
            this.Controls.Add(this.picSuccessMessageIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessMessage";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSuccessMessageIcon)).EndInit();
            this.panHoldButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSuccessMessageIcon;
        private Bunifu.Framework.UI.BunifuElipse ElipseSuccessMessageDialog;
        private Bunifu.Framework.UI.BunifuDragControl SuccessMessageDragControl;
        private Bunifu.Framework.UI.BunifuThinButton2 btnok;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCommentGrate;
        private System.Windows.Forms.Panel panHoldButton;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
    }
}