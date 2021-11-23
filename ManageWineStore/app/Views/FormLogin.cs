﻿using ManageWineStore.app.Controllers;
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
                this.Show();
            }
        }

        private bool validate()
        {
            return true;
        }
    }
}
