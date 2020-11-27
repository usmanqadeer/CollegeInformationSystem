﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeInformationSystem.InformitionDialod
{
    public partial class DeleteMessage : Form
    {
        public DeleteMessage()
        {
            InitializeComponent();
        }

        private void btnokay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public static void SHowDialog(string message)
        {
            DeleteMessage dm = new CollegeInformationSystem.InformitionDialod.DeleteMessage();
            dm.ShowDialog();
        }
    }
}
