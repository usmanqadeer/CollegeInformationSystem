namespace CollegeInformationSystem.InformitionDialod
{
    partial class ErrorMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorMessage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorMessageDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ElipseErrorMessage = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panHoldButton = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnok = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCommentOops = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panHoldButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorMessageDragControl
            // 
            this.ErrorMessageDragControl.Fixed = true;
            this.ErrorMessageDragControl.Horizontal = true;
            this.ErrorMessageDragControl.TargetControl = this.pictureBox1;
            this.ErrorMessageDragControl.Vertical = true;
            // 
            // ElipseErrorMessage
            // 
            this.ElipseErrorMessage.ElipseRadius = 20;
            this.ElipseErrorMessage.TargetControl = this;
            // 
            // panHoldButton
            // 
            this.panHoldButton.BackColor = System.Drawing.Color.White;
            this.panHoldButton.Controls.Add(this.btnCancel);
            this.panHoldButton.Controls.Add(this.btnok);
            this.panHoldButton.Location = new System.Drawing.Point(24, 208);
            this.panHoldButton.Name = "panHoldButton";
            this.panHoldButton.Size = new System.Drawing.Size(230, 50);
            this.panHoldButton.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 2;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IdleBorderThickness = 2;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            this.btnCancel.IdleForecolor = System.Drawing.Color.White;
            this.btnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnCancel.Location = new System.Drawing.Point(22, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnok
            // 
            this.btnok.ActiveBorderThickness = 2;
            this.btnok.ActiveCornerRadius = 20;
            this.btnok.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnok.ActiveForecolor = System.Drawing.Color.White;
            this.btnok.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnok.BackColor = System.Drawing.Color.White;
            this.btnok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnok.BackgroundImage")));
            this.btnok.ButtonText = "ok";
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.IdleBorderThickness = 2;
            this.btnok.IdleCornerRadius = 20;
            this.btnok.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnok.IdleForecolor = System.Drawing.Color.White;
            this.btnok.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            this.btnok.Location = new System.Drawing.Point(118, 0);
            this.btnok.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(84, 45);
            this.btnok.TabIndex = 0;
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(6, 180);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(287, 25);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Your opration not successfuly completed.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.UseCompatibleTextRendering = true;
            // 
            // lblCommentOops
            // 
            this.lblCommentOops.AutoSize = true;
            this.lblCommentOops.BackColor = System.Drawing.Color.White;
            this.lblCommentOops.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentOops.Location = new System.Drawing.Point(107, 145);
            this.lblCommentOops.Name = "lblCommentOops";
            this.lblCommentOops.Size = new System.Drawing.Size(74, 32);
            this.lblCommentOops.TabIndex = 6;
            this.lblCommentOops.Text = "oops!";
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 270);
            this.Controls.Add(this.panHoldButton);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblCommentOops);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorMessage";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorMessage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panHoldButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl ErrorMessageDragControl;
        private Bunifu.Framework.UI.BunifuElipse ElipseErrorMessage;
        private System.Windows.Forms.Panel panHoldButton;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnok;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCommentOops;
    }
}