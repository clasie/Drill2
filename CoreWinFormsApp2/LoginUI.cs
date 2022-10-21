using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreWinFormsApp2
{
    public partial class LoginUI : Form
    {
        public bool IsLogged = false;
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Entrer des creds");
                return;
            }
            else if (txtLogin.Text == "a" && txtPassword.Text == "a")
            {
                IsLogged = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Entrer des creds valables");
                return;
            }
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDownManagement(sender, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDownManagement(sender, e);
        }
        private void KeyDownManagement(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnValidation.PerformClick();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            IsLogged = false;
        }
    }
}
