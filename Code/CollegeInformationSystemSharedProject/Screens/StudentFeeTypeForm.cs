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
    public partial class SetFeeTypeForm : Form
    {
        DataTable dtFee = new DataTable();
        int index = 0;
        public SetFeeTypeForm()
        {
            InitializeComponent();
        }

        private void SetFeeTypeForm_Load(object sender, EventArgs e)
        {
            //StudentFeeDataGridView.DataSource = LogicKernal.FeeType.GetAllFeeType();
            //dtFee = LogicKernal.FeeType.GetAllFeeType();
            //ShowData();
        }
        private void ShowData()
        {
            if (dtFee.Rows.Count == 0)
                return;

            txtFeeType.Text = dtFee.Rows[index]["FeeTypeName"].ToString();
            txtRemarks.Text = dtFee.Rows[index]["Remarks"].ToString();
            chkIsEnabled.Checked = Convert.ToBoolean(dtFee.Rows[index]["IsEnabled"]);
            txtFeeType.Tag = Convert.ToInt32(dtFee.Rows[index]["FeeTypeID"]);
            lblRecord.Text = (index + 1).ToString() + "/" + dtFee.Rows.Count.ToString();
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
            if (index == dtFee.Rows.Count - 1)
                return;

            index++;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = dtFee.Rows.Count - 1;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFeeType.ReadOnly = false;
            txtFeeType.Text = "";
            txtFeeType.Tag = 0;

            txtRemarks.ReadOnly = false;
            txtRemarks.Text = "";
            chkIsEnabled.Enabled = true;
            chkIsEnabled.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtRemarks.ReadOnly = false;
            txtRemarks.ReadOnly = false;
            chkIsEnabled.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //BusinessEntities.FeeType fee = new BusinessEntities.FeeType();
            //fee.FeeTypeID = Convert.ToInt32(txtFeeType.Tag);
            //fee.FeeTypeName = txtFeeType.Text;
            //fee.Remarks = txtRemarks.Text;
            //fee.AddByID = Convert.ToInt32(this.Tag);
            //fee.AddDateTime = System.DateTime.Now;
            //fee.IsEnabled = chkIsEnabled.Checked;
            //int degree_id = LogicKernal.FeeType.InsertUpdateFeeType(fee);
            //txtFeeType.Tag = degree_id;
            //if (degree_id > 0)
            //{
            //    MessageBox.Show("Record Entered Successfully");

            //}

            //else
            //{
            //    MessageBox.Show("Error: Degree Not Added");
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
