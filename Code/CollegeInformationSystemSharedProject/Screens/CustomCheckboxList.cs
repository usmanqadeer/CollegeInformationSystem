using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections;

namespace CollegeInformationSystem
{
    public partial class CustomCheckboxList : UserControl
    {

        private int row_height = 25;
        private int column_width = 150;
        [TypeConverter("System.Windows.Forms.Design.DataSourceConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [Editor("System.Windows.Forms.Design.DataSourceListEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        private List<StudentSubject> dataSource;

        public List<StudentSubject> DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }


        public int SelectedIndex { get; set; }
        public CustomCheckboxList()
        {
            InitializeComponent();

        }

        public ArrayList GetSelectedItems()
        {
            ArrayList lstSelectedItems = new ArrayList();
            foreach (Control ctrl in this.Controls)
            {
                CheckBox chkSelectedItem = (CheckBox)ctrl;
                if (chkSelectedItem.Checked)

                    lstSelectedItems.Add(chkSelectedItem.Tag);

            }

            return lstSelectedItems;
        }
        private void CustomCheckboxList_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        [System.ComponentModel.Browsable(false)]
        public void DataBind()
        {
            try
            {
                dataSource = StudentSubjectController.StudentSubjectSelectAll();
                if (dataSource.Count == 0)
                    return;

                int top = 5;
                int left = 5;
                int columns_count = Convert.ToInt32(Math.Round(Convert.ToDouble(this.Width) / 150));
                int column_remaining = columns_count;

                foreach (var drStudentSubject in dataSource)
                {
                    StudentSubject objStudentSubject = new StudentSubject();


                    objStudentSubject.SubjectID = drStudentSubject.SubjectID;
                    objStudentSubject.SubjectName = drStudentSubject.SubjectName;
                    objStudentSubject.InsertByID = drStudentSubject.InsertByID;
                    objStudentSubject.InsertDataTime = drStudentSubject.InsertDataTime;
                    objStudentSubject.LastUpdateID = drStudentSubject.LastUpdateID;
                    objStudentSubject.LastUpdateTime = drStudentSubject.LastUpdateTime;
                    objStudentSubject.Remarks = drStudentSubject.Remarks;
                    objStudentSubject.IsEnabeled = drStudentSubject.IsEnabeled;


                    CheckBox chkSubject = new CheckBox();
                    chkSubject.Text = drStudentSubject.SubjectName.ToString();
                    chkSubject.Tag = objStudentSubject;
                    chkSubject.AutoSize = false;
                    chkSubject.Width = 150;

                    chkSubject.Location = new Point(left, top);
                    this.Controls.Add(chkSubject);
                    column_remaining--;

                    if (column_remaining == 0)
                    {
                        top += row_height;
                        left = 5;
                        column_remaining = columns_count;
                    }
                    else
                        left += 150;
                }
            }
            catch (Exception ex) { }

        }


    }
}
