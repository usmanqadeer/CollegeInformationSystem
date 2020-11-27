using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CollegeInformationSystem.InformitionDialod;
namespace CollegeInformationSystem
{
    public partial class SetSectionForm : Form
    {
        List<StudentSections> sections = StudentSectionsController.StudentSectionsSelectAll();
        List<StudentSession> studentSessions = StudentSessionController.StudentSessionSelectAll();
        int index = 0;
        public SetSectionForm()
        {
            InitializeComponent();
        }
        private void SetSectionForm_Load(object sender, EventArgs e)
        {

            cmbStudentSession.DataSource = studentSessions;
            cmbStudentSession.DisplayMember = "SessionName";
            cmbStudentSession.ValueMember = "SessionID";
            cmbStudentSession.Tag = "SessinID";
            //cmbStudentSession.SelectedIndex = 0;

            StudentSectionDataGridView.DataSource = sections;
            ShowData();

        }
        private void ShowData()
        {

            try
            {
                if (sections.Count <= 0)
                    return;

                txtSectionName.Text = sections[index].SectionName;
                txtSectionRemarks.Text = sections[index].Remarks;
                chkIsEnabled.Checked = Convert.ToBoolean(sections[index].IsEnabled);
                txtSectionName.Tag = Convert.ToInt32(sections[index].SectionID);
                lblRecord.Text = (index + 1).ToString() + "/" + sections.Count.ToString();
  
    }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex));
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
            if (sections.Count <= 0)
                return;

            index++;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = sections.Count - 1;
            ShowData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StudentSections studentSections = new StudentSections();
                studentSections.SectionID = Convert.ToInt32(txtSectionName.Tag);
                studentSections.SectionName = txtSectionName.Text;
                studentSections.SessionID = Convert.ToInt64(cmbStudentSession.SelectedValue);
                studentSections.CreatedDateTime = System.DateTime.Now;
                studentSections.CreatedByID = Convert.ToInt32(this.Tag);
                studentSections.LastUpdateByID = Convert.ToInt32(this.Tag);
                studentSections.LastUpdateDateTime = System.DateTime.Now;
                studentSections.IsEnabled = chkIsEnabled.Checked;
                studentSections.Remarks = txtSectionRemarks.Text;

                long section_id = StudentSectionsController.InsertUpdateStudentSections(studentSections);
                txtSectionName.Tag = section_id;
                if (section_id > 0)
                {

                    SuccessMessage.SHowDialog("Record Entered Successfully ");
                    StudentSectionDataGridView.DataSource = sections;
                }

                else
                {
                    WarningMessage.SHowDialog("Error: Section Not Added");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSectionName.ReadOnly = false;
            txtSectionName.Text = "";
            txtSectionName.Tag = 0;

            txtSectionRemarks.ReadOnly = false;
            txtSectionRemarks.Text = "";
            chkIsEnabled.Enabled = true;
            chkIsEnabled.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtSectionName.ReadOnly = false;
            txtSectionRemarks.ReadOnly = false;
            chkIsEnabled.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
