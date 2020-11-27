using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    public partial class StudentRegistrationForm : Form
    {
        public StudentRegistrationForm()
        {
            InitializeComponent();
            
        }

        private void cmbInterMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbEducationSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEducationSystem.SelectedIndex.Equals(0))
            {
                cmbAnnual.Enabled = false;
                cmbSelectSemester.Enabled = true;


            }
            else
            {
                cmbAnnual.Enabled = true;
                cmbSelectSemester.Enabled = false;
            }
        }

        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
