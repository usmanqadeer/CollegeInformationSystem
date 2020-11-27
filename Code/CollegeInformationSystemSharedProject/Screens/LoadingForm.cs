﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            
            lblUserNameLogin.Text = Convert.ToString(this.Text);

            this.Opacity = 0.0;
            timer1.Start();
            circularProgressBar.Value = 0;
            circularProgressBar.Maximum = 0;
            circularProgressBar.Maximum = 100;
           
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar.Value += 1;
            circularProgressBar.Text = circularProgressBar.Value.ToString();
            if (circularProgressBar.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

       
    }
}
