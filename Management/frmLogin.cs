using Repository.Models;
using Repository.Services;
using System.Reflection.Metadata;

namespace Management
{
    public partial class frmLogin : Form
    {
        UserServices _user = new UserServices();
        public frmLogin()
        {
            InitializeComponent();
            List<TblUser> tblUsers = _user.GetAll();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var user = _user.GetAll().Where(x => x.UserId == txtUsername.Text && x.Password == txtPassword.Text).FirstOrDefault();
            if (user != null)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnSignIn_Click(sender, e);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnSignIn_Click(sender, e);
            }
        }
    }
}