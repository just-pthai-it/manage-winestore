using ManageWineStore.app.Controllers;
using ManageWineStore.app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FormLogin : Form
    {
        private LoginController loginController;
        public FormLogin()
        {
            InitializeComponent();
            loginController = new LoginController();
            this.ActiveControl = this.txtUsername;
        }

        private void confirmBt_Click(object sender, EventArgs e)
        {
            Object user = null;

            if (validate())
            {
                user = loginController.login(txtUsername.Text, txtPassword.Text);
            }


            if (user != null)
            {
                FormHome form = new FormHome(loginController.AccountModel, user);
                this.Hide();
                form.ShowDialog();
                this.txtUsername.Text = "";
                this.txtPassword.Text = "";
                this.Show();
            }
            else
            {
                this.label1.Visible = true;
            }
        }

        private bool validate()
        {
            return true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.label1.Visible = false;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.label1.Visible = false;
        }

        private void ExitBt_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", 
                            "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
