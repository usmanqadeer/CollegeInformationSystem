using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    public partial class StudentDegreeForm : Form
    {
        List<StudentDegree> studentDegrees = new List<StudentDegree>();
        StudentDegree student = new StudentDegree();
        int index = 0;

        public StudentDegreeForm()
        {
            InitializeComponent();
        }
       
        private void frmStudentDegree_Load(object sender, EventArgs e)
        {
            StudentDegreesDataGridView.DataSource = student.StudentDegreeSelectAll();
            studentDegrees = student.StudentDegreeSelectAll();
            ShowData();
            
        }

        private void ShowData()
        {
            if (studentDegrees.Count == 0)
                return;

            txtDegreeName.Text = studentDegrees[index].DegreeName;
            txtDegreeRemarks.Text = studentDegrees[index].Remarks;
            chkIsEnabled.Checked = Convert.ToBoolean(studentDegrees[index].IsEnabled);
            txtDegreeName.Tag = Convert.ToInt32(studentDegrees[index].DegreeID);
            lblRecord.Text = (index + 1).ToString() + "/" + studentDegrees.Count.ToString();
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
            if (index == studentDegrees.Count - 1)
                return;

            index++;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = studentDegrees.Count - 1;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDegreeName.ReadOnly = false;
            txtDegreeName.Text = "";
            txtDegreeName.Tag = 0;

            txtDegreeRemarks.ReadOnly = false;
            txtDegreeRemarks.Text = "";
            chkIsEnabled.Enabled = true;
            chkIsEnabled.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtDegreeName.ReadOnly = false;
            txtDegreeRemarks.ReadOnly = false;
            chkIsEnabled.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentDegree degree = new StudentDegree();
            degree.DegreeID = Convert.ToInt32(txtDegreeName.Tag);
            degree.DegreeName = txtDegreeName.Text;
            degree.Remarks = txtDegreeRemarks.Text;
            degree.CreatedByID = Convert.ToInt32(this.Tag);
            degree.CreatedDateTime = System.DateTime.Now;
            degree.LastUpdateByID = Convert.ToInt32(this.Tag);
            degree.LastUpdateTime = System.DateTime.Now;
            degree.IsEnabled = chkIsEnabled.Checked;
            long degree_id = degree.InsertUpdateStudentDegree();
            txtDegreeName.Tag = degree_id;
            if (degree_id > 0)
            {
                MessageBox.Show("Record Entered Successfully");

            }

            else
            {
                MessageBox.Show("Error: Degree Not Added");
            }
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
