using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using CollegeInformationSystem.InformitionDialod;
using System.Collections.Generic;

namespace CollegeInformationSystem
{
    public partial class UserRegestrationForm : Form
    {
        List<CollageAdmin> collageAdmins = new List<CollageAdmin>();
        CollageAdmin objCollageAdmin = new CollageAdmin();

        ImageConverter imgConverter = new ImageConverter();
        // Create class-level accesible variables
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;


        // Declare required methods
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {

            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);
            try
            {
                if (capture.IsOpened())
                {
                    while (isCameraRunning)
                    {

                        capture.Read(frame);
                        image = BitmapConverter.ToBitmap(frame);
                        if (picUser.Image != null)
                        {
                            picUser.Image.Dispose();
                        }
                        picUser.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public UserRegestrationForm()
        {
            InitializeComponent();
        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
       
        private void UserRegestrationForm_Load(object sender, EventArgs e)
        {

            //DataGrid fill all admin
            UserDataGridView.DataSource = CollageAdminController.CollageAdminSelectAll();

           

        }

        private void btnUsertPicture_Click(object sender, EventArgs e)
        {
            if (btnUsertPicture.Text.Equals("Start"))
            {
                CaptureCameraCallback();
                CaptureCamera();
                btnUsertPicture.Text = "Stop";
                isCameraRunning = true;
            }
            else
            {
                capture.Release();
                btnUsertPicture.Text = "Start";
                isCameraRunning = false;
                picUser.Image = null;
            }
        }

        private void btnUserPictureCapture_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                VideoCapture capture = new VideoCapture();
                btnUserPictureCapture.Image = btnUserPictureCapture.Image;

                isCameraRunning = false;
            }
            else
            {
                isCameraRunning = true;

            }
        }
        private Boolean IsFormValidate()
        {
            if (txtUserName.Text.Equals(string.Empty))
            {
                
                WarningMessage.SHowDialog("Please Fil ..");
                txtUserName.Focus();
                return false;
            }
            else if (txtUserPassword.Text.Equals(string.Empty))
            {
                WarningMessage.SHowDialog("Please Fil ..");
                txtUserPassword.Focus();
                return false;
            }
            else if (txtUserContactNo.Text.Equals(string.Empty))
            {
             
                WarningMessage.SHowDialog("Please Fil ..");
                txtUserContactNo.Focus();
                return false;
               
            }
            else if (txtUserEmail.Text.Equals(string.Empty))
            {
                WarningMessage.SHowDialog("Please Fil ..");
                txtUserEmail.Focus();
                return false;
            }
            else if (txtUserCNIC.Text.Equals(string.Empty))
            {
                WarningMessage.SHowDialog("Please Fil ..");
                txtUserCNIC.Focus();
                return false;
            }
            else if (cmbUserRole.Text.Equals(string.Empty))
            {
                WarningMessage.SHowDialog("Please Fil ..");
                cmbUserRole.Focus();
                return false;
            }

            else if (txtUserRemarks.Text.Equals(string.Empty))
            {
                WarningMessage.SHowDialog("Please Fil ..");
                txtUserRemarks.Focus();
                return true;
            }
            else
            {
                return true;
            }
            
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            Image admin_pic = picUser.Image;
            admin_pic.Save("images//admin//" + txtUserCNIC.Text + ".jpg");

            if (IsFormValidate())
            {
               
                CollageAdmin objAdmin = new CollageAdmin();
               
                objAdmin.UserId = Convert.ToInt32(txtUserName.Tag);
                objAdmin.UserEmail = txtUserEmail.Text;
                objAdmin.UserName = txtUserName.Text;
                objAdmin.UserPassword = txtUserPassword.Text;
                objAdmin.UserRole = cmbUserRole.Text;
                objAdmin.UserContectNo = txtUserContactNo.Text;
                objAdmin.UserCNIC = txtUserCNIC.Text;
                objAdmin.AddedById = Convert.ToInt32(this.Tag);
                objAdmin.AddedByDateTime = DateTime.Now;
                objAdmin.UserIsEnabled = true;
                objAdmin.LastEnableDateTime = DateTime.Now;
                objAdmin.Remarks = txtUserRemarks.Text;
                objAdmin.UserPic = "images//admin//" + txtUserCNIC.Text + ".jpg";

                long UserId = objAdmin.InsertUpdateCollageAdmin();

                if (UserId > 0)

                {
                    UserDataGridView.DataSource = CollageAdminController.CollageAdminSelectAll();
                    SuccessMessage.SHowDialog("Record Entered Successfully");
                    txtUserName.Focus();
                  
                }
                else
                {
                    ErrorMessage.SHowDialog("Error in Entry");
                    txtUserName.Focus();
                }
            }
        }
            
           
    }
}
