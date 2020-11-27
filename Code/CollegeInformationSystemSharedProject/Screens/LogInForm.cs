using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CollegeInformationSystem.InformitionDialod;

namespace CollegeInformationSystem
{
    public partial class LogInFrom : Form
    {
        public LogInFrom()
        {
            InitializeComponent();
            AnimateLoginForm.Start();
        }
        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region Placeholder or WaterMark
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Name")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.LightGray;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Name";
                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void txtUserPassword_Enter(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "Password")
            {
                txtUserPassword.Text = "";
                txtUserPassword.ForeColor = Color.LightGray;
                txtUserPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUserPassword_Leave(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "")
            {
                txtUserPassword.Text = "Password";
                txtUserPassword.ForeColor = Color.Silver;
                txtUserPassword.UseSystemPasswordChar = false;
            }
        }

        #endregion 
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "" + msg;
            lblErrorMessage.Visible = true;
            picErrorMessage.Visible = true;
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            picErrorMessage.Visible = false;
            lblErrorMessage.Visible = false;
        }
        private bool isFromValidate()
        {
            if (txtUserName.Text == "Name" && txtUserPassword.Text == "Password")
            {
                msgError("Please Enter User Name/Password.");
                txtUserName.Focus();
                return false;
            }
            else if (txtUserName.Text == "Name" && txtUserName.TextLength > 2)
            {
                msgError("Pleace Enter User Name.");
                txtUserName.Focus();
                return false;
            }
            else if (txtUserPassword.Text == "Password")
            {
                msgError("Pleace Enter User Password.");
                txtUserPassword.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUserPassword.Text = "Password";
            txtUserPassword.UseSystemPasswordChar = false;
            txtUserName.Text = "Username";
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (isFromValidate())
            {
                long user_id = CollageAdminController.UserLogIn(txtUserName.Text,txtUserPassword.Text);
                if (user_id == 0)
                {
                    msgError("Incorrect username or password entered.\n Please try again.");
                    txtUserPassword.Text = "Password";
                    txtUserPassword.UseSystemPasswordChar = false;
                    txtUserName.Focus();
                    return;
                }
                this.Hide();
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Text = txtUserName.Text;
                loadingForm.Tag = user_id;
                loadingForm.ShowDialog();

                DashBoardForm dashBoardForm = new DashBoardForm();
                dashBoardForm.Tag = user_id;
                dashBoardForm.Name = txtUserName.Text;
                dashBoardForm.Show();
                dashBoardForm.FormClosed += Logout;
                this.Hide();
            }
        }
    }
}
