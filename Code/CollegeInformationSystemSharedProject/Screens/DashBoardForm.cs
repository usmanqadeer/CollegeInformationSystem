using CollegeInformationSystem.Screens;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    public partial class DashBoardForm : Form
    {

        // Fields
        private IconButton currentBtn;
        private Form currentChildForm;


        //Builder
        public DashBoardForm()
        {
            InitializeComponent();

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = MaximizedBounds;
            this.Opacity = 100;
        }
        #region Drag Form/ on screen 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DashBoardForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region Structs of colors/ Methods Activate Button/DisableButton
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(190, 171, 12);
            public static Color color2 = Color.FromArgb(148, 0, 211);
            public static Color color3 = Color.FromArgb(95, 158, 160);
            public static Color color4 = Color.FromArgb(139, 0, 139);
            public static Color color5 = Color.FromArgb(0, 100, 0);
            public static Color color6 = Color.FromArgb(255, 127, 80);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;

                currentBtn.IconColor = color;


                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;


            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(22, 34, 48);
                currentBtn.ForeColor = Color.Gainsboro;

                currentBtn.IconColor = Color.FromArgb(46, 139, 87);

            }
        }
        #endregion
        private void OpenChildForm(Form childForm)
        {
            // open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            // End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panFormContainer.Controls.Add(childForm);
            panFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Tag = lblID.Text;
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void OpenChildFormOutOfPanel(Form childForm)
        {
            // open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.Tag = lblID.Text;
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();

            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        #region Event to expend collaps panel
        private void ExapandCollapse(object sender, EventArgs e)
        {

            Button btHeader = (Button)sender;
            Panel parent = (Panel)btHeader.Parent;
            if (parent.Height == 50)
            {

                ActivateButton(sender, RGBColors.color5);
                parent.Height = Convert.ToInt32(parent.Tag);


            }

            else
            {
                ActivateButton(sender, RGBColors.color5);
                parent.Height = 50;

            }

        }
        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            Reset();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new UserRegestrationForm());
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color6);

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);

            OpenChildForm(new AddNewStudentForm());

        }

        private void btnStudentRegistration_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new StudentRegistrationForm());
        }

        private void btnAddStudentBlackList_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color2);
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
        }

        private void timerFachatDateTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            try
            {

                lblID.Text = Convert.ToString(this.Tag);
                lblName.Text = Convert.ToString(this.Name);
                ShowInfoemationDataBase();
                string activeUserPic = CollageAdminController.ActiveUserLogInInfo(Convert.ToInt32(this.Tag));

                picActiveUser.Image = System.Drawing.Image.FromFile(activeUserPic);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void ShowInfoemationDataBase()
        {


        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)


                this.Close();

        }

        private void btnDegrees_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildFormOutOfPanel(new StudentDegreeForm());
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildFormOutOfPanel(new StudentProgramForm());
        }

        private void btnSecession_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            SetSectionForm setSectionForm = new SetSectionForm();
            setSectionForm.Show();
        }

        private void btnStudentFee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new StudentFeeForm());
        }

        private void btnStudentSession_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildFormOutOfPanel(new StudentSessionForm());
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildFormOutOfPanel(new StudentSubjectForm());
        }

        private void btnDAEMajor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildFormOutOfPanel(new DAEMajorForm());

        }
        private void ShowData()
        {

        }

        private void bunifuCharts1_Load(object sender, EventArgs e)
        {



        }
        private void Daly_Tick(object sender, EventArgs e)
        {

            Daly.Stop();
            List<StudentDegree> studentDegrees = new List<StudentDegree>();
            studentDegrees = StudentDegreeController.StudentDegreeSelectAll();
            lblTotalDegree.Text = studentDegrees.Count.ToString();
            StudentDegree studentDegree = new StudentDegree();
            studentDegrees = studentDegree.StudentDegreeSelectAll();
            List<StudentProgram> studentPrograms = new List<StudentProgram>();
            StudentProgram studentProgram = new StudentProgram();
            
            studentPrograms = studentProgram.StudentProgramSelectAll();
            lblProgramTotal.Text = studentPrograms.Count.ToString();
            List<CollageAdmin> collageAdmins = CollageAdminController.CollageAdminSelectAll();
            lblTotalAdmin.Text = collageAdmins.Count.ToString();
            List<StudentPersonalInfo> studentPersonalInfos = StudentPersonalInfoController.StudentPersonalInfoSelectAll();
            lblTotalStudent.Text = studentPersonalInfos.Count.ToString();
            List<StudentSections> studentSections = StudentSectionsController.StudentSectionsSelectAll();
            lblTotalSection.Text = studentSections.Count.ToString();
            Bunifu.DataViz.Data data = new Bunifu.DataViz.Data();
            Bunifu.DataViz.DataPoint dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.column);
            Random r = new Random();
            dataPoint.addLabely("Degrees", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint.addLabely("Users", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint.addLabely("Program", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint.addLabely("Degrees", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint.addLabely("Users", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint.addLabely("Program", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());


            data.addData(dataPoint);
            CollumChart.Render(data);
            Bunifu.DataViz.Data data1 = new Bunifu.DataViz.Data();
            Bunifu.DataViz.DataPoint dataPoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.pie);

            dataPoint2.addLabely("Degrees", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint2.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint2.addLabely("Users", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint2.addLabely("Program", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint2.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint2.addLabely("Degrees", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint2.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint2.addLabely("Users", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint2.addLabely("Program", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint2.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());


            data1.addData(dataPoint2);
            bunifuCharts1.Render(data1);
            Bunifu.DataViz.Data data2 = new Bunifu.DataViz.Data();

            Bunifu.DataViz.DataPoint dataPoint3 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);

            dataPoint3.addLabely("Degrees", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint3.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint3.addLabely("Users", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint3.addLabely("Program", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint3.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint3.addLabely("Degrees", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint3.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            
            dataPoint3.addLabely("Program", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint3.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());


            data2.addData(dataPoint3);
            bunifuCharts2.Render(data2);

            Bunifu.DataViz.Data data3 = new Bunifu.DataViz.Data();

            Bunifu.DataViz.DataPoint dataPoint4 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.area);

            dataPoint4.addLabely("Degrees", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint4.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint4.addLabely("Users", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint4.addLabely("Program", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint4.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint4.addLabely("Degrees", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint4.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());
            dataPoint4.addLabely("Program", r.Next(0, Convert.ToInt32(studentDegrees.Count.ToString())).ToString());
            dataPoint4.addLabely("Program", r.Next(0, Convert.ToInt32(studentPrograms.Count.ToString())).ToString());


            data3.addData(dataPoint4);
            bunifuCharts3.Render(data3);
        }

        private void btnReligion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildFormOutOfPanel(new ReligionForm());
        }
    }
}
