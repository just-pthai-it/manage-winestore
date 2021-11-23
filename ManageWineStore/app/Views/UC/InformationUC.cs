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
using Views;

namespace ManageWineStore.app.Views.UC
{
    public partial class InformationUC : UserControl
    {
        private PersonalInforController personalInforController = new PersonalInforController();
        private AccountModel accountModel = null;
        private EmployeeModel employeeModel = null;
        private AdminModel adminModel = null;

        public InformationUC(AccountModel accountModel, Object user)
        {
            InitializeComponent();
            this.setUp(accountModel, user);
        }

        private void setUp(AccountModel accountModel, Object user)
        {
            this.accountModel = accountModel;
            this.loadGenderCbbData();
            this.loadAccountData();
                
            if (user.GetType() == typeof(AdminModel))
            {
                this.adminModel = (AdminModel)user;
                this.loadAdminData();
            }
            else
            {
                this.employeeModel = (EmployeeModel)user;
                this.loadJobCbbData();
                this.loadEmployeeData();
            }
        }

        private void loadAccountData()
        {
            this.txtUsername.Text = accountModel.Username;
            this.txtPassword.Text = accountModel.Password;
        }

        public void loadAdminData()
        {
            this.txtName.Text = adminModel.Name;
            this.txtPhone.Text = adminModel.Phone;
            this.txtMail.Text = adminModel.Mail;
            this.txtAddress.Text = adminModel.Address;
            this.genderCbb.SelectedValue = adminModel.Gender.ToString();
            this.birthDtp.Value = adminModel.Birth;
            this.pictureBox.Image = ImageHandler.bytesToImage(adminModel.Image);
        }

        public void loadEmployeeData()
        {
            this.txtName.Text = employeeModel.Name;
            this.txtPhone.Text = employeeModel.Phone;
            this.txtMail.Text = employeeModel.Mail;
            this.txtAddress.Text = employeeModel.Address;
            this.genderCbb.SelectedValue = employeeModel.Gender.ToString();
            this.birthDtp.Value = employeeModel.Birth;
            this.jobCbb.SelectedValue = employeeModel.JobId.ToString();
            this.pictureBox.Image = ImageHandler.bytesToImage(employeeModel.Image);
        }

        private void loadJobCbbData()
        {
            this.jobCbb.DisplayMember = "job_name";
            this.jobCbb.ValueMember = "id";
            this.jobCbb.DataSource = this.personalInforController.getJobs();
        }

        private void loadGenderCbbData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("name");

            DataRow row = dataTable.NewRow();
            row["id"] = "0";
            row["name"] = "Nữ";
            dataTable.Rows.Add(row);
            DataRow row1 = dataTable.NewRow();
            row1["id"] = "1";
            row1["name"] = "Nam";
            dataTable.Rows.Add(row1);

            this.genderCbb.DisplayMember = "name";
            this.genderCbb.ValueMember = "id";
            this.genderCbb.DataSource = dataTable;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (this.adminModel != null)
            {

                this.adminModel = this.personalInforController.updateAdminInfo(this.loadNewAdminData());
            }
            else
            {
                this.employeeModel = this.personalInforController.updateEmployeeInfo(this.loadNewEmployeeData());
            }

            this.submitBtn.Enabled = false;
            this.cancelBtn.Enabled = false;
            this.selectImageBt.Enabled = false;
            this.updateBtn.Enabled = true;
            this.isEditable(false);

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (this.adminModel != null)
            {
                this.loadAdminData();
            }
            else
            {
                this.loadEmployeeData();
            }

            this.submitBtn.Enabled = false;
            this.cancelBtn.Enabled = false;
            this.selectImageBt.Enabled = false;
            this.updateBtn.Enabled = true;
            this.isEditable(false);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!this.validate())
            {
                return;
            }

            this.submitBtn.Enabled = true;
            this.cancelBtn.Enabled = true;
            this.selectImageBt.Enabled = true;
            this.updateBtn.Enabled = false;
            this.isEditable(true);
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            FormChangePass form = new FormChangePass(accountModel);
            form.ShowDialog();
        }

        private void selectImageBt_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathImage = null;
                this.openFileDialog1.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                this.openFileDialog1.FilterIndex = 1;
                this.openFileDialog1.RestoreDirectory = true;
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePathImage = this.openFileDialog1.FileName;
                    this.pictureBox.Image = Image.FromFile(filePathImage.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra!\nThao tác không thể thực hiện");
                return;
            }
        }

        private AdminModel loadNewAdminData()
        {
            return new AdminModel(this.adminModel.Id,
                                this.txtName.Text,
                                birthDtp.Value,
                                int.Parse(genderCbb.SelectedValue.ToString()),
                                this.txtPhone.Text,
                                this.txtMail.Text,
                                this.txtAddress.Text,
                                this.adminModel.AccountId,
                                ImageHandler.imageToBytes(this.pictureBox.Image));
        }

        private EmployeeModel loadNewEmployeeData()
        {
            return new EmployeeModel(this.employeeModel.Id,
                                    this.txtName.Text,
                                    birthDtp.Value,
                                    int.Parse(genderCbb.SelectedValue.ToString()),
                                    this.txtPhone.Text,
                                    this.txtMail.Text,
                                    this.txtAddress.Text,
                                    int.Parse(jobCbb.SelectedValue.ToString()),
                                    this.employeeModel.AccountId,
                                    ImageHandler.imageToBytes(this.pictureBox.Image));
        }

        private bool validate()
        {
            if (this.txtUsername.Text == "" ||
                this.txtPhone.Text == "" ||
                this.txtMail.Text == "" ||
                this.txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }

            return true;
        }

        private void isEditable(bool status)
        {
            this.txtName.ReadOnly = !status;
            this.txtPhone.ReadOnly = !status;
            this.txtMail.ReadOnly = !status;
            this.txtAddress.ReadOnly = !status;
            this.genderCbb.Enabled = status;
            this.birthDtp.Enabled = status;
        }
    }
}
