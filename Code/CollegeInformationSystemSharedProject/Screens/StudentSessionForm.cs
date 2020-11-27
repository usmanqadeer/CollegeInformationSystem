using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    public partial class StudentSessionForm : Form
    {
        List<StudentSession> studentSessions = new List<StudentSession>();
        StudentSession sessions = new StudentSession();
        int index = 0;

        public StudentSessionForm()
        {
            InitializeComponent();
        }

        private void StudentSessionForm_Load(object sender, EventArgs e)
        {
            StudentSessionDataGridView.DataSource = sessions.StudentSessionSelectAll();
            studentSessions = sessions.StudentSessionSelectAll();
            ShowData();
        }
        private void ShowData()
        {
            try
            {
                if (studentSessions.Count <= 0)
                    return;

                txtSession.Text = studentSessions[index].SessionName;
                txtRemarks.Text = studentSessions[index].Remarks;
                chkIsEnabled.Checked = studentSessions[index].IsEnabeled;
                txtSession.Tag = Convert.ToInt32(studentSessions[index].SessionID);
                lblRecord.Text = (index + 1).ToString() + "/" + studentSessions.Count.ToString();
            }
            catch (Exception  ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index == 0)
                return;
            index--;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (studentSessions.Count > 0)
                return;

            index++;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = studentSessions.Count - 1;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSession.ReadOnly = false;
            txtSession.Text = "";
            txtSession.Tag = 0;
          
            txtRemarks.ReadOnly = false;
            txtRemarks.Text = "";
            chkIsEnabled.Enabled = true;
            chkIsEnabled.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtSession.ReadOnly = false;
            txtRemarks.ReadOnly = false;
            chkIsEnabled.Enabled = true;
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           StudentSession student_Sessions = new StudentSession();
            student_Sessions.SessionID = Convert.ToInt32(txtSession.Tag);
            student_Sessions.SessionName = txtSession.Text;
            
            student_Sessions.Remarks = txtRemarks.Text;
            student_Sessions.InsertByID = Convert.ToInt32(this.Tag);
            student_Sessions.InsertDataTime = System.DateTime.Now;
            student_Sessions.IsEnabeled = chkIsEnabled.Checked;
            student_Sessions.LastUpdateID = Convert.ToInt32(this.Tag);
            student_Sessions.LastUpdateTime = System.DateTime.Now;
            long degree_id = student_Sessions.InsertUpdateStudentSession();
            txtSession.Tag = degree_id;
            if (degree_id > 0)
            {
                StudentSessionDataGridView.DataSource = 
                MessageBox.Show("Record Entered Successfully");

            }

            else
            {
                MessageBox.Show("Error: Degree Not Added");
            }
        }
    }
}
