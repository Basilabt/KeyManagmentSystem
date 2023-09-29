using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessAccessLayer;

namespace ActivationKeyGenerator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private  void _login()
        {


            if (_isEmptyTextBoxes())
            {
                _showErrorMessgaeBox("Please enter username and password !");
                return;
            }


            string username = txtboxUsername.Text.ToString();
            string password = txtboxPassword.Text.ToString();

            clsUser loggedUser = clsUser.login(username, password);




            if (loggedUser == null)
            {
                _showErrorMessgaeBox("Incorrect username or password !");
                return;

            }
            else if (loggedUser.isActive == false)
            {
                _showErrorMessgaeBox("Failed to login becasue user is NOT active !");
                return;

            }
            else
            {
                clsUser.recordSuccessfullLogin(loggedUser.userID, DateTime.Now);
                _showMainForm(loggedUser);
                _hideLoginForm();
            }

        }
  

        private void frmLogin_Load(object sender, EventArgs e)
        {

        
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            _login();
        }


        private bool _isEmptyTextBoxes()
        {
            return txtboxPassword.Text.ToString() == "" || txtboxUsername.Text.ToString() == "";
        }

        private void _showErrorMessgaeBox(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _showMainForm(clsUser loggedUser)
        {
            frmMain main = new frmMain(loggedUser);
            main.Show();
        }

        private void _hideLoginForm()
        {
            this.Hide();
        }
    }
}
