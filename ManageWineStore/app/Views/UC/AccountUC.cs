using ManageWineStore.app.BussinessClasses;
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

namespace ManageWineStore.app.Views.UC
{
    public partial class AccountUC : UserControl
    {
        private AccountManageController accountManageController = new AccountManageController();
        public AccountUC()
        {
            InitializeComponent();
            this.setUp();
        }
        
        private void setUp()
        {
            this.loadKeyCbbData();
            this.loadRoleCbbData();
            this.loadData();
            this.setDGVHeaders();
        }

        private void loadKeyCbbData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("column");
            dataTable.Columns.Add("text");

            DataRow row = dataTable.NewRow();
            row["column"] = "id";
            row["text"] = "Mã TK";
            DataRow row2 = dataTable.NewRow();
            row2["column"] = "username";
            row2["text"] = "Tên TK";
            DataRow row3 = dataTable.NewRow();
            row3["column"] = "role";
            row3["text"] = "Vai trò";

            dataTable.Rows.Add(row);
            dataTable.Rows.Add(row2);
            dataTable.Rows.Add(row3);

            this.keyCbb.DisplayMember = "text";
            this.keyCbb.ValueMember = "column";
            this.keyCbb.DataSource = dataTable;
        }

        private void loadRoleCbbData()
        {
            this.roleCbb.DisplayMember = "description";
            this.roleCbb.ValueMember = "id";
            this.roleCbb.DataSource = accountManageController.getRoles();
        }

        private void loadData()
        {
            this.dgv.DataSource = this.accountManageController.getAccounts();
        }

        private void setDGVHeaders()
        {
            this.dgv.Columns["id"].HeaderText = "Mã TK";
            this.dgv.Columns["username"].HeaderText = "Tên TK";
            this.dgv.Columns["role"].HeaderText = "Vai trò";
            this.dgv.Columns["password"].Visible = false;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            this.updateBt.Enabled = false;
            this.deleteBt.Enabled = false;
            this.isEditable(true);
            this.clear();
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgv.SelectedRows[0];
            if (row.Cells[0] == null)
            {
                return;
            }

            this.addBt.Enabled = false;
            this.deleteBt.Enabled = false;
            this.isEditable(true);

            this.txtId.Text = row.Cells[0].Value.ToString();
            this.txtUsername.Text = row.Cells[1].Value.ToString();
            this.txtPassword.Text = row.Cells[3].Value.ToString();
            this.txtRepeatPassword.Text = row.Cells[3].Value.ToString();
            this.roleCbb.Text = row.Cells[2].Value.ToString();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgv.SelectedRows[0];
            if (row.Cells[0] == null)
            {
                return;
            }

            this.accountManageController.removeAccount(row.Cells[0].Value.ToString());
            this.loadData();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            if (!this.validate())
            {
                return;
            }

            AccountModel accountModel = null;
            try
            {
                accountModel = new AccountModel(
                                this.txtId.Text == "" ? null : (int?)int.Parse(this.txtId.Text),
                                this.txtUsername.Text,
                                this.addBt.Enabled ? MD5Helper.GetHash(this.txtPassword.Text) :
                                                    this.txtPassword.Text,
                                int.Parse(this.roleCbb.SelectedValue.ToString()));
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return;
            }

            if (this.addBt.Enabled == true)
            {
                this.accountManageController.createAccount(accountModel);
            }
            else
            {
                this.accountManageController.updateAccount(accountModel);
            }

            this.loadData();
            this.reset();
            this.isEditable(false);
        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            this.loadData();
            this.reset();
            this.isEditable(false);
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.reset();
            this.isEditable(false);
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            if (this.txtKeyword.Text == "")
            {
                return;
            }

            this.dgv.DataSource = this.accountManageController.search(this.keyCbb.SelectedValue.ToString(),
                                                                        this.txtKeyword.Text);
        }

        private bool validate()
        {
            if (this.txtUsername.Text == "" ||
                this.txtPassword.Text == "" ||
                this.txtRepeatPassword.Text == "" ||
                this.txtPassword.Text != this.txtRepeatPassword.Text)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập");
                return false;
            }

            return true;
        }

        private bool verifyPassword()
        {
            if (this.txtPassword.Text == "" ||
                this.txtRepeatPassword.Text == "" ||
                this.txtPassword.Text != this.txtRepeatPassword.Text)
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu");
                return false;
            }

            return true;
        }

        private void reset()
        {
            this.clear();
            this.updateBt.Enabled = true;
            this.addBt.Enabled = true;
            this.deleteBt.Enabled = true;
        }

        private void clear()
        {
            this.txtId.Text = "";
            this.txtUsername.Text = "";
            this.txtPassword.Text = "";
            this.txtRepeatPassword.Text = "";
            this.txtKeyword.Text = "";
        }

        private void isEditable(bool status)
        {
            if (this.addBt.Enabled)
            {
                this.txtUsername.Enabled = status;
                this.txtPassword.Enabled = status;
                this.txtRepeatPassword.Enabled = status;
            }

            this.roleCbb.Enabled = status;
            this.saveBt.Enabled = status;
            this.cancelBt.Enabled = status;
        }
    }
}
