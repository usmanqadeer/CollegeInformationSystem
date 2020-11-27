using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CollegeInformationSystem.InformitionDialod;
namespace CollegeInformationSystem.Screens
{
    public partial class ReligionForm : Form
    {
        List<AllReligion> religions = AllReligionController.AllReligionSelectAll();
        
        int index = 0;
        public ReligionForm()
        {
            InitializeComponent();
        }

        private void frmReligion_Load(object sender, EventArgs e)
        {
            StudentReligionDataGridView.DataSource = religions;
            ShowData();
        }
        private void ShowData()
        {
            try
            {
                if (religions.Count <= 0)
                    return;

                txtReligion.Text = religions[index].ReligionName;
                txtRemarks.Text = religions[index].Remarks;
                chkIsEnabled.Checked = religions[index].IsEnable;
                txtReligion.Tag = Convert.ToInt32(religions[index].ReligionID);
                lblRecord.Text = (index + 1).ToString() + "/" + religions.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AllReligion religion = new AllReligion();

            religion.ReligionID = 0;
            religion.ReligionName = txtReligion.Text;
            religion.AddByID = Convert.ToInt32(this.Tag);
            religion.AddByDateTime = System.DateTime.Now;
            religion.LastUpDateByID = Convert.ToInt32(this.Tag);
            religion.LastUpdateDateTime = System.DateTime.Now;
            religion.IsEnable = true;
            religion.Remarks = txtRemarks.Text;

            Int64 religion_Id = AllReligionController.InsertUpdateAllReligion(religion);
            if(religion_Id > 0)
            {
                SuccessMessage.SHowDialog("Religin Entered Successfully");
            }
            else
            {
                ErrorMessage.SHowDialog("Religin not entered successfully");
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
            if (religions.Count > 0)
                return;

            index++;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = religions.Count - 1;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtReligion.ReadOnly = false;
            txtReligion.Text = "";
            txtReligion.Tag = 0;

            txtRemarks.ReadOnly = false;
            txtRemarks.Text = "";
            chkIsEnabled.Enabled = true;
            chkIsEnabled.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtReligion.ReadOnly = false;
            txtReligion.ReadOnly = false;
            txtReligion.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
