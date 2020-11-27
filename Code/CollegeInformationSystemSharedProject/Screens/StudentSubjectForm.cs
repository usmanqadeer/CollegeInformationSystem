using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CollegeInformationSystem.InformitionDialod;
namespace CollegeInformationSystem
{
    public partial class StudentSubjectForm : Form
    {
        List<StudentSubject> studentSubjects = new List<StudentSubject>();
        int index = 0;
        public StudentSubjectForm()
        {
            InitializeComponent();
        }

        private void SetSemesterForm_Load(object sender, EventArgs e)
        {
            studentSubjects = StudentSubjectController.StudentSubjectSelectAll();
            StudentSubjectDataGridView.DataSource = StudentSubjectController.StudentSubjectSelectAll();
            ShowData();
        }
        private void ShowData()
        {
            if (studentSubjects.Count == 0)
                return;
            txtSubjectName.Tag = studentSubjects[index].SubjectID;
            txtSubjectName.Text = studentSubjects[index].SubjectName;
            txtRemarks.Text = studentSubjects[index].Remarks;
            chkIsEnabled.Checked = Convert.ToBoolean(studentSubjects[index].IsEnabeled);
            txtSubjectName.Tag = Convert.ToInt32(studentSubjects[index].SubjectID);
            lblRecord.Text = (index + 1).ToString() + "/" + studentSubjects.Count.ToString();
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
            if (studentSubjects.Count == (index + 1))
                return;

            index++;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = studentSubjects.Count - 1;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSubjectName.ReadOnly = false;
            txtSubjectName.Text = "";
            txtSubjectName.Tag = 0;

            txtRemarks.ReadOnly = false;
            txtRemarks.Text = "";
            chkIsEnabled.Enabled = true;
            chkIsEnabled.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtRemarks.ReadOnly = false;
            txtSubjectName.ReadOnly = false;
            chkIsEnabled.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentSubject studentSubject = new StudentSubject();
            studentSubject.SubjectID = Convert.ToInt64(txtSubjectName.Tag);
            studentSubject.SubjectName = txtSubjectName.Text;
            studentSubject.InsertByID = Convert.ToInt32(this.Tag);
            studentSubject.InsertDataTime = System.DateTime.Now;
            studentSubject.LastUpdateID = Convert.ToInt32(this.Tag);
            studentSubject.LastUpdateTime = System.DateTime.Now;
            studentSubject.IsEnabeled = chkIsEnabled.Checked;
            studentSubject.Remarks = txtRemarks.Text;

            Int64 subjec_id = StudentSubjectController.InsertUpdateStudentSubject(studentSubject);
            txtSubjectName.Tag = subjec_id;
            if (subjec_id > 0)
            {
                SuccessMessage.SHowDialog("Record Entered Successfully");

            }

            else
            {
                ErrorMessage.SHowDialog("Degree Not Added Successfully");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void panHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
