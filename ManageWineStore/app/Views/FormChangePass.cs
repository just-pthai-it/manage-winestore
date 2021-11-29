﻿using ManageWineStore.app.BussinessClasses;
using ManageWineStore.app.Controllers.ModelControllers;
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
    public partial class FormChangePass : Form
    {
        private AccountController accountController = new AccountController();
        private AccountModel accountModel = null;
        public FormChangePass(AccountModel accountModel)
        {
            InitializeComponent();
            this.accountModel = accountModel;
        }

        private void checkPasswordBt_Click(object sender, EventArgs e)
        {
            this.verifyPassword();
        }

        private void verifyPassword()
        {
            if (this.txtCurrentPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            DataTable dataTable =
               accountController.findByUsernameAndPassword(accountModel.Username,
                                                            MD5Helper.GetHash(this.txtCurrentPassword.Text));

            if (dataTable.Rows.Count == 0)
            {
                this.notifiyLabel.Visible = true;
                return;
            }

            this.notifiyLabel.Visible = true;
            this.notifiyLabel.Text = "Mật khẩu chính xác";
            this.notifiyLabel.ForeColor = Color.Green;

            this.txtCurrentPassword.Enabled = false;
            this.checkPasswordBt.Enabled = false;

            this.txtNewPassword.Enabled = true;
            this.txtComfirmPassword.Enabled = true;
            this.comfirmBt.Enabled = true;
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            this.notifiyLabel.Visible = false;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            this.label4.Visible = false;
        }

        private void txtComfirmPassword_TextChanged(object sender, EventArgs e)
        {
            this.label4.Visible = false;
        }

        private bool validate()
        {
            if (this.txtNewPassword.Text != this.txtComfirmPassword.Text)
            {
                this.label4.Visible = true;
                return false;
            }

            return true;
        }

        private void comfirmBt_Click(object sender, EventArgs e)
        {
            this.comfirm();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrentPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.verifyPassword();
            }
        }

        private void comfirm()
        {
            if (this.validate())
            {
                this.accountModel.Password = MD5Helper.GetHash(this.txtNewPassword.Text);
                this.accountController.update(this.accountModel);
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                this.Close();
            }
        }
    }
}
