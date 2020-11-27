using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CollegeInformationSystem.InformitionDialod;
namespace CollegeInformationSystem.Screens
{
    public partial class DAEMajorForm : Form
    {
        List<DAEStudentMajor> dAEStudentMajors = DAEStudentMajorController.DAEStudentMajorSelectAll();

        int index = 0;
        public DAEMajorForm()
        {
            InitializeComponent();
        }
        private void DAEMajorForm_Load(object sender, EventArgs e)
        {

            StudentDAEDataGridView.DataSource = dAEStudentMajors;
            ShowData();
        }
        private void ShowData()
        {
            try
            {
                if (dAEStudentMajors.Count <= 0)
                    return;

                txtDAEMajor.Text = dAEStudentMajors[index].DAEName;
                txtRemarks.Text = dAEStudentMajors[index].Remarks;
                chkIsEnabled.Checked = dAEStudentMajors[index].IsEnabled;
                txtDAEMajor.Tag = Convert.ToInt32(dAEStudentMajors[index].DAEMajorID);
                lblRecord.Text = (index + 1).ToString() + "/" + dAEStudentMajors.Count.ToString();
            }
            catch (Exception ex)
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
            if (dAEStudentMajors.Count > 0)
                return;

            index++;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = dAEStudentMajors.Count - 1;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDAEMajor.ReadOnly = false;
            txtDAEMajor.Text = "";
            txtDAEMajor.Tag = 0;

            txtRemarks.ReadOnly = false;
            txtRemarks.Text = "";
            chkIsEnabled.Enabled = true;
            chkIsEnabled.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtDAEMajor.ReadOnly = false;
            txtRemarks.ReadOnly = false;
            chkIsEnabled.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAEStudentMajor dAEStudentMajor = new DAEStudentMajor();

            dAEStudentMajor.DAEMajorID= 0;
            dAEStudentMajor.DAEName = txtDAEMajor.Text;
            dAEStudentMajor.AddByID = Convert.ToInt32(this.Tag);
            dAEStudentMajor.AddByDateTime = System.DateTime.Now;
            dAEStudentMajor.LastUpdateID = Convert.ToInt32(this.Tag);
            dAEStudentMajor.LastUpdateDateTime = System.DateTime.Now;
            dAEStudentMajor.Remarks = txtRemarks.Text;

            Int64 dEA_Id = DAEStudentMajorController.InsertUpdateDAEStudentMajor(dAEStudentMajor);
            if (dEA_Id > 0)
            {
                SuccessMessage.SHowDialog("DAE Entered Successfully");
            }
            else
            {
                ErrorMessage.SHowDialog("DAE not entered successfully");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

       
    }
}
