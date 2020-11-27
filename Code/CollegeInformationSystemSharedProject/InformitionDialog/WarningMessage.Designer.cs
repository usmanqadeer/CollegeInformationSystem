namespace CollegeInformationSystem.InformitionDialod
{
    partial class WarningMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningMessage));
            this.picWorningMessage = new System.Windows.Forms.PictureBox();
            this.WorningMessageDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ElipseWorningMessage = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panHoldButton = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnok = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCommentWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWorningMessage)).BeginInit();
            this.panHoldButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // picWorningMessage
            // 
            this.picWorningMessage.Image = ((System.Drawing.Image)(resources.GetObject("picWorningMessage.Image")));
            this.picWorningMessage.Location = new System.Drawing.Point(-5, -8);
            this.picWorningMessage.Name = "picWorningMessage";
            this.picWorningMessage.Size = new System.Drawing.Size(322, 294);
            this.picWorningMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorningMessage.TabIndex = 0;
            this.picWorningMessage.TabStop = false;
            // 
            // WorningMessageDragControl
            // 
            this.WorningMessageDragControl.Fixed = true;
            this.WorningMessageDragControl.Horizontal = true;
            this.WorningMessageDragControl.TargetControl = this.picWorningMessage;
            this.WorningMessageDragControl.Vertical = true;
            // 
            // ElipseWorningMessage
            // 
            this.ElipseWorningMessage.ElipseRadius = 20;
            this.ElipseWorningMessage.TargetControl = this;
            // 
            // panHoldButton
            // 
            this.panHoldButton.BackColor = System.Drawing.Color.White;
            this.panHoldButton.Controls.Add(this.lblMessage);
            this.panHoldButton.Controls.Add(this.btnok);
            this.panHoldButton.Location = new System.Drawing.Point(41, 159);
            this.panHoldButton.Name = "panHoldButton";
            this.panHoldButton.Size = new System.Drawing.Size(230, 109);
            this.panHoldButton.TabIndex = 11;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(243, 25);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Sorry correct infomation required.\r\n";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.UseCompatibleTextRendering = true;
            // 
            // btnok
            // 
            this.btnok.ActiveBorderThickness = 2;
            this.btnok.ActiveCornerRadius = 20;
            this.btnok.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnok.ActiveForecolor = System.Drawing.Color.White;
            this.btnok.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnok.BackColor = System.Drawing.Color.White;
            this.btnok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnok.BackgroundImage")));
            this.btnok.ButtonText = "ok";
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.IdleBorderThickness = 2;
            this.btnok.IdleCornerRadius = 20;
            this.btnok.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnok.IdleForecolor = System.Drawing.Color.White;
            this.btnok.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(63)))));
            this.btnok.Location = new System.Drawing.Point(58, 41);
            this.btnok.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(118, 45);
            this.btnok.TabIndex = 0;
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblCommentWarning
            // 
            this.lblCommentWarning.AutoSize = true;
            this.lblCommentWarning.BackColor = System.Drawing.Color.White;
            this.lblCommentWarning.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentWarning.Location = new System.Drawing.Point(88, 116);
            this.lblCommentWarning.Name = "lblCommentWarning";
            this.lblCommentWarning.Size = new System.Drawing.Size(138, 40);
            this.lblCommentWarning.TabIndex = 9;
            this.lblCommentWarning.Text = "Warning!";
            // 
            // WarningMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 280);
            this.Controls.Add(this.panHoldButton);
            this.Controls.Add(this.lblCommentWarning);
            this.Controls.Add(this.picWorningMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarningMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorningMessage";
            ((System.ComponentModel.ISupportInitialize)(this.picWorningMessage)).EndInit();
            this.panHoldButton.ResumeLayout(false);
            this.panHoldButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWorningMessage;
        private Bunifu.Framework.UI.BunifuDragControl WorningMessageDragControl;
        private Bunifu.Framework.UI.BunifuElipse ElipseWorningMessage;
        private System.Windows.Forms.Panel panHoldButton;
        private System.Windows.Forms.Label lblMessage;
        private Bunifu.Framework.UI.BunifuThinButton2 btnok;
        private System.Windows.Forms.Label lblCommentWarning;
    }
}