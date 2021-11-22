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
    public partial class EmployeeUC : UserControl
    {
        private EmployeeManageController employeeManageController = new EmployeeManageController();
        public EmployeeUC()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.loadData();
            this.setDGVHeaders();
            this.loadJobCbbData();
            this.loadGenderCbbData();
            this.loadKeyCbbData();
        }

        private void loadJobCbbData()
        {
            this.jobCbb.DisplayMember = "job_name";
            this.jobCbb.ValueMember = "id";
            this.jobCbb.DataSource = this.employeeManageController.getJobs();
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

        private void loadKeyCbbData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("column");
            dataTable.Columns.Add("text");

            DataRow row = dataTable.NewRow();
            row["column"] = "id";
            row["text"] = "Mã NV";
            DataRow row2 = dataTable.NewRow();
            row2["column"] = "name";
            row2["text"] = "Họ tên";
            DataRow row3 = dataTable.NewRow();
            row3["column"] = "job_name";
            row3["text"] = "Công việc";
            DataRow row4 = dataTable.NewRow();
            row4["column"] = "gender";
            row4["text"] = "Giới tính";
            DataRow row5 = dataTable.NewRow();
            row5["column"] = "address";
            row5["text"] = "Địa chỉ";

            dataTable.Rows.Add(row);
            dataTable.Rows.Add(row2);
            dataTable.Rows.Add(row3);
            dataTable.Rows.Add(row4);
            dataTable.Rows.Add(row5);

            this.keyCbb.DisplayMember = "text";
            this.keyCbb.ValueMember = "column";
            this.keyCbb.DataSource = dataTable;
        }

        private void loadData()
        {
            this.dgv.DataSource = this.employeeManageController.getEmployees();
        }

        private void setDGVHeaders()
        {
            this.dgv.Columns["id"].HeaderText = "Mã NV";
            this.dgv.Columns["name"].HeaderText = "Họ tên";
            this.dgv.Columns["job_name"].HeaderText = "Công việc";
            this.dgv.Columns["birth"].HeaderText = "Ngày sinh";
            this.dgv.Columns["gender"].HeaderText = "Giới tính";
            this.dgv.Columns["phone"].HeaderText = "SĐT";
            this.dgv.Columns["mail"].HeaderText = "Mail";
            this.dgv.Columns["address"].HeaderText = "Địa chỉ";
            this.dgv.Columns["account_id"].HeaderText = "Mã TK";
            this.dgv.Columns["image"].Visible = false;
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
            this.txtName.Text = row.Cells[1].Value.ToString();
            this.txtPhone.Text = row.Cells[5].Value.ToString();
            this.txtMail.Text = row.Cells[6].Value.ToString();
            this.txtAddress.Text = row.Cells[7].Value.ToString();
            this.txtAccountId.Text = row.Cells[8].Value.ToString();

            this.birthDtp.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            this.genderCbb.Text = row.Cells[4].Value.ToString();
            this.jobCbb.Text = row.Cells[2].Value.ToString();
            this.pictureBox.Image = ImageHandler.bytesToImage((byte[])row.Cells[9].Value);
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgv.SelectedRows[0];
            if (row.Cells[0] == null)
            {
                return;
            }

            this.employeeManageController.removeEmployee(row.Cells[0].Value.ToString());
            this.loadData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!this.validate())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            EmployeeModel employeeModel = null;
            try
            {
                employeeModel = new EmployeeModel(
                this.txtId.Text == "" ? null : (int?)int.Parse(this.txtId.Text),
                this.txtName.Text,
                this.birthDtp.Value,
                int.Parse(this.genderCbb.SelectedValue.ToString()),
                this.txtPhone.Text,
                this.txtMail.Text,
                this.txtAddress.Text,
                int.Parse(this.jobCbb.SelectedValue.ToString()),
                this.txtAccountId.Text == "" ? null : (int?)int.Parse(this.txtAccountId.Text),
                ImageHandler.imageToBytes(this.pictureBox.Image));
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return;
            }

            if (this.addBt.Enabled == true)
            {
                this.employeeManageController.createEmployee(employeeModel);
            }
            else
            {
                this.employeeManageController.updateEmployee(employeeModel);
            }

            this.loadData();
            this.reset();
            this.isEditable(false);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.reset();
            this.isEditable(false);
        }

        private bool validate()
        {
            if (this.txtName.Text == "" ||
                this.txtPhone.Text == "" ||
                this.txtMail.Text == "" ||
                this.txtAddress.Text == "" ||
                this.pictureBox.Image == null)
            {
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
            this.txtName.Text = "";
            this.txtPhone.Text = "";
            this.txtMail.Text = "";
            this.txtAddress.Text = "";
            this.txtAccountId.Text = "";
            this.txtKeyword.Text = "";
            this.pictureBox.Image = null;
        }
        private void searchBt_Click(object sender, EventArgs e)
        {
            if (this.txtKeyword.Text == "")
            {
                return;
            }

            this.dgv.DataSource = this.employeeManageController.search(this.keyCbb.SelectedValue.ToString(),
                                                                    this.txtKeyword.Text);
        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            this.loadData();
            this.reset();
            this.isEditable(false);
        }

        private void selectImgBt_Click(object sender, EventArgs e)
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
                return;
            }
        }

        private void isEditable(bool status)
        {
            this.txtName.Enabled = status;
            this.birthDtp.Enabled = status;
            this.genderCbb.Enabled = status;
            this.jobCbb.Enabled = status;
            this.txtPhone.Enabled = status;
            this.txtMail.Enabled = status;
            this.txtAddress.Enabled = status;
            this.txtAccountId.Enabled = status;
            this.pictureBox.Enabled = status;

            this.saveBt.Enabled = status;
            this.cancelBt.Enabled = status;
            this.selectImgBt.Enabled = status;
        }
    }
}
