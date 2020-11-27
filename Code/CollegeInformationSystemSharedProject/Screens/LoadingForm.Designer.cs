namespace CollegeInformationSystem
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picUserActive = new System.Windows.Forms.PictureBox();
            this.lblUserNameLogin = new System.Windows.Forms.Label();
            this.panHeader = new System.Windows.Forms.Panel();
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUserActive)).BeginInit();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(339, 57);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(174, 37);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "    WELCOME";
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 500;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar.ForeColor = System.Drawing.Color.Silver;
            this.circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(382, 125);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.circularProgressBar.ProgressWidth = 25;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.circularProgressBar.Size = new System.Drawing.Size(130, 130);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "%";
            this.circularProgressBar.TabIndex = 2;
            this.circularProgressBar.Text = "0";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picUserActive
            // 
            this.picUserActive.Image = ((System.Drawing.Image)(resources.GetObject("picUserActive.Image")));
            this.picUserActive.Location = new System.Drawing.Point(-2, 53);
            this.picUserActive.Name = "picUserActive";
            this.picUserActive.Size = new System.Drawing.Size(219, 216);
            this.picUserActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserActive.TabIndex = 8;
            this.picUserActive.TabStop = false;
            // 
            // lblUserNameLogin
            // 
            this.lblUserNameLogin.AutoSize = true;
            this.lblUserNameLogin.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameLogin.ForeColor = System.Drawing.Color.White;
            this.lblUserNameLogin.Location = new System.Drawing.Point(413, 94);
            this.lblUserNameLogin.Name = "lblUserNameLogin";
            this.lblUserNameLogin.Size = new System.Drawing.Size(18, 21);
            this.lblUserNameLogin.TabIndex = 9;
            this.lblUserNameLogin.Text = ",,";
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panHeader.Controls.Add(this.lblCollegeName);
            this.panHeader.Controls.Add(this.lblSystem);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(676, 53);
            this.panHeader.TabIndex = 7;
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.AutoSize = true;
            this.lblCollegeName.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeName.ForeColor = System.Drawing.Color.White;
            this.lblCollegeName.Location = new System.Drawing.Point(2, 0);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(66, 30);
            this.lblCollegeName.TabIndex = 11;
            this.lblCollegeName.Text = "Glims\r\n";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.White;
            this.lblSystem.Location = new System.Drawing.Point(3, 27);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(139, 21);
            this.lblSystem.TabIndex = 10;
            this.lblSystem.Text = "Education System";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(676, 269);
            this.Controls.Add(this.lblUserNameLogin);
            this.Controls.Add(this.picUserActive);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.circularProgressBar);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserActive)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picUserActive;
        private System.Windows.Forms.Label lblUserNameLogin;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.Label lblSystem;
    }
}