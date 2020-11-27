using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CollegeInformationSystem.InformitionDialod;
namespace CollegeInformationSystem.Screens
{
    public partial class StudentProgramForm : Form
    {
        List<StudentDegree> studentDegrees = StudentDegreeController.StudentDegreeSelectAll();

        List<StudentProgram> studentPrograms = StudentProgramController.StudentProgramSelectAll();
        int index = 0;
        public StudentProgramForm()
        {
            InitializeComponent();
        }

        private void StudentProgramForm_Load(object sender, EventArgs e)
        {

            try
            {
                cmbStudentDegree.DataSource = studentDegrees;
                cmbStudentDegree.DisplayMember = "DegreeName";
                cmbStudentDegree.ValueMember = "DegreeID";
                cmbStudentDegree.SelectedIndex = 0;
                cmbStudentDegree.Tag = "DegreeID";

                StudentProgramDataGridView.DataSource = studentPrograms;
                ShowData();
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void ShowData()
        {
          
            try
            {
                if (studentPrograms.Count == 0)
                    return;

                txtProgramName.Text = studentPrograms[index].ProgramName;
                txtProgramRemarks.Text = studentPrograms[index].Remarks;
                txtProgramRemarks.Tag = Convert.ToInt32(studentPrograms[index].DegreeID);
                chkIsEnabled.Checked = studentPrograms[index].IsEnabled;
                txtProgramName.Tag = Convert.ToInt32(studentPrograms[index].ProgramID);
                lblRecord.Text = (index + 1).ToString() + "/" + studentPrograms.Count.ToString();

               

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (studentPrograms.Count > 0)
                return;

            index++;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = studentPrograms.Count - 1;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbStudentDegree.SelectedIndex = 0;
            cmbStudentDegree.Enabled = true;

            cmbStudentDegree.Enabled = true;
            txtProgramName.ReadOnly = false;
            txtProgramName.Text = "";
            txtProgramName.Tag = 0;

            txtProgramRemarks.ReadOnly = false;
            txtProgramRemarks.Text = "";
            chkIsEnabled.Enabled = true;
            chkIsEnabled.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtProgramName.ReadOnly = false;
            txtProgramRemarks.ReadOnly = false;
            chkIsEnabled.Enabled = true;
            cmbStudentDegree.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentProgram studentProgram = new StudentProgram();

            studentProgram.ProgramID = Convert.ToInt32(txtProgramName.Tag);
            studentProgram.ProgramName = txtProgramName.Text;
            studentProgram.DegreeID = Convert.ToInt64(cmbStudentDegree.SelectedValue);
            studentProgram.CreatedByID = Convert.ToInt32(this.Tag);
            studentProgram.CreatedDateTime = System.DateTime.Now;
            studentProgram.LastUpdateID = Convert.ToInt32(this.Tag);
            studentProgram.LastUpdateDateTime = System.DateTime.Now;
            studentProgram.IsEnabled = chkIsEnabled.Checked;
            studentProgram.Remarks = txtProgramRemarks.Text;

            long degree_id = StudentProgramController.InsertUpdateStudentProgram(studentProgram);
            txtProgramName.Tag = degree_id;
            if (degree_id > 0)
            {

                SuccessMessage.SHowDialog("Record Entered Successfully");
                StudentProgramDataGridView.DataSource = studentPrograms;

            }
            else
            {
                ErrorMessage.SHowDialog("Record Not Entered Successfully Error!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

