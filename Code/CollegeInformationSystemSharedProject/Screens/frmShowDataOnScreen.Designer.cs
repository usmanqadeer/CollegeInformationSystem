namespace CollegeInformationSystem.Screens
{
    partial class frmShowDataOnScreen
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
            this.bunifuCharts2 = new Bunifu.DataViz.BunifuCharts();
            this.bunifuCharts1 = new Bunifu.DataViz.BunifuCharts();
            this.BarChart = new Bunifu.DataViz.BunifuCharts();
            this.Daly = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bunifuCharts2
            // 
            this.bunifuCharts2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCharts2.animationEnabled = true;
            this.bunifuCharts2.AxisXFontColor = System.Drawing.Color.Silver;
            this.bunifuCharts2.AxisXGridColor = System.Drawing.Color.LimeGreen;
            this.bunifuCharts2.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuCharts2.AxisYFontColor = System.Drawing.Color.GreenYellow;
            this.bunifuCharts2.AxisYGridColor = System.Drawing.Color.DarkCyan;
            this.bunifuCharts2.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuCharts2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuCharts2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCharts2.Location = new System.Drawing.Point(1908, 1034);
            this.bunifuCharts2.Margin = new System.Windows.Forms.Padding(25, 31, 25, 31);
            this.bunifuCharts2.Name = "bunifuCharts2";
            this.bunifuCharts2.Size = new System.Drawing.Size(794, 0);
            this.bunifuCharts2.TabIndex = 25;
            this.bunifuCharts2.Theme = Bunifu.DataViz.BunifuCharts._theme.theme3;
            this.bunifuCharts2.Title = "";
            // 
            // bunifuCharts1
            // 
            this.bunifuCharts1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCharts1.animationEnabled = true;
            this.bunifuCharts1.AxisXFontColor = System.Drawing.Color.Silver;
            this.bunifuCharts1.AxisXGridColor = System.Drawing.Color.LimeGreen;
            this.bunifuCharts1.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuCharts1.AxisYFontColor = System.Drawing.Color.GreenYellow;
            this.bunifuCharts1.AxisYGridColor = System.Drawing.Color.DarkCyan;
            this.bunifuCharts1.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuCharts1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuCharts1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCharts1.Location = new System.Drawing.Point(345, 1034);
            this.bunifuCharts1.Margin = new System.Windows.Forms.Padding(17, 21, 17, 21);
            this.bunifuCharts1.Name = "bunifuCharts1";
            this.bunifuCharts1.Size = new System.Drawing.Size(1131, 0);
            this.bunifuCharts1.TabIndex = 24;
            this.bunifuCharts1.Theme = Bunifu.DataViz.BunifuCharts._theme.theme3;
            this.bunifuCharts1.Title = "";
            // 
            // BarChart
            // 
            this.BarChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarChart.animationEnabled = true;
            this.BarChart.AxisXFontColor = System.Drawing.Color.Silver;
            this.BarChart.AxisXGridColor = System.Drawing.Color.LimeGreen;
            this.BarChart.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BarChart.AxisYFontColor = System.Drawing.Color.GreenYellow;
            this.BarChart.AxisYGridColor = System.Drawing.Color.DarkCyan;
            this.BarChart.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BarChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BarChart.ForeColor = System.Drawing.Color.Silver;
            this.BarChart.Location = new System.Drawing.Point(2062, 381);
            this.BarChart.Margin = new System.Windows.Forms.Padding(17, 21, 17, 21);
            this.BarChart.Name = "BarChart";
            this.BarChart.Size = new System.Drawing.Size(598, 611);
            this.BarChart.TabIndex = 23;
            this.BarChart.Theme = Bunifu.DataViz.BunifuCharts._theme.theme3;
            this.BarChart.Title = "";
            // 
            // Daly
            // 
            this.Daly.Tick += new System.EventHandler(this.Daly_Tick);
            // 
            // frmShowDataOnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 446);
            this.Controls.Add(this.bunifuCharts2);
            this.Controls.Add(this.bunifuCharts1);
            this.Controls.Add(this.BarChart);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmShowDataOnScreen";
            this.ShowInTaskbar = false;
            this.Text = "frmShowDataOnScreen";
            this.Load += new System.EventHandler(this.frmShowDataOnScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.DataViz.BunifuCharts bunifuCharts2;
        private Bunifu.DataViz.BunifuCharts bunifuCharts1;
        private Bunifu.DataViz.BunifuCharts BarChart;
        private System.Windows.Forms.Timer Daly;
    }
}