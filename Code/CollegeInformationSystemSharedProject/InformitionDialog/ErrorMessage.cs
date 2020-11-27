using System;
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
    public partial class ErrorMessage : Form
    {
        public ErrorMessage(string _message)
        {
            InitializeComponent();
            lblMessage.Text = _message;
            btnok.Focus();
        }
        
        private void btnok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public static void SHowDialog(string message)
        {
            ErrorMessage em = new CollegeInformationSystem.InformitionDialod.ErrorMessage(message);
            em.ShowDialog();
        }
    }
}
