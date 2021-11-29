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
    public partial class SupplierUC : UserControl
    {
        private SupplierManageController supplierManageController = new SupplierManageController();

        public SupplierUC()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.loadKeyCbbData();
            this.loadNationCbb();
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
            row["text"] = "Mã NCC";
            DataRow row2 = dataTable.NewRow();
            row2["column"] = "name";
            row2["text"] = "Tên NCC";
            DataRow row3 = dataTable.NewRow();
            row3["column"] = "address";
            row3["text"] = "Địa chỉ";
            DataRow row4 = dataTable.NewRow();
            row4["column"] = "nation";
            row4["text"] = "Quốc gia";

            dataTable.Rows.Add(row);
            dataTable.Rows.Add(row2);
            dataTable.Rows.Add(row3);
            dataTable.Rows.Add(row4);

            this.keyCbb.DisplayMember = "text";
            this.keyCbb.ValueMember = "column";
            this.keyCbb.DataSource = dataTable;
        }

        private void loadNationCbb()
        {
            this.nationCbb.DisplayMember = "name";
            this.nationCbb.ValueMember = "id";
            this.nationCbb.DataSource = this.supplierManageController.getNations();
        }

        private void loadData()
        {
            this.dgv.DataSource = this.supplierManageController.getSupplilers();
        }

        private void setDGVHeaders()
        {
            this.dgv.Columns["id"].HeaderText = "Mã NCC";
            this.dgv.Columns["name"].HeaderText = "Tên NCC";
            this.dgv.Columns["phone"].HeaderText = "SĐT";
            this.dgv.Columns["mail"].HeaderText = "Mail";
            this.dgv.Columns["address"].HeaderText = "Địa chỉ";
            this.dgv.Columns["nation"].HeaderText = "Quốc gia";
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            if (this.txtKeyword.Text == "")
            {
                return;
            }

            this.dgv.DataSource = this.supplierManageController.search(this.keyCbb.SelectedValue.ToString(),
                                                                    this.txtKeyword.Text);
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
            this.txtPhone.Text = row.Cells[2].Value.ToString();
            this.txtMail.Text = row.Cells[3].Value.ToString();
            this.txtAddress.Text = row.Cells[4].Value.ToString();
            this.nationCbb.Text = row.Cells[5].Value.ToString();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu?",
                            "Xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            DataGridViewRow row = this.dgv.SelectedRows[0];
            if (row.Cells[0] == null)
            {
                return;
            }

            this.supplierManageController.removeSupplier(row.Cells[0].Value.ToString());
            this.loadData();
        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            this.loadData();
            this.reset();
            this.isEditable(false);
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            if (!this.validate())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            SupplierModel supplierModel = null;
            try
            {
                supplierModel = new SupplierModel(
                            this.txtId.Text == "" ? null : (int?)int.Parse(this.txtId.Text),
                            this.txtName.Text,
                            this.txtPhone.Text,
                            this.txtMail.Text,
                            this.txtAddress.Text,
                            int.Parse(this.nationCbb.SelectedValue.ToString()));
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return;
            }

            if (this.addBt.Enabled == true)
            {
                this.supplierManageController.createSupplier(supplierModel);
            }
            else
            {
                this.supplierManageController.updateSupplier(supplierModel);
            }

            this.loadData();
            this.reset();
            this.isEditable(false);
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.reset();
            this.isEditable(false);
        }


        private bool validate()
        {
            if (this.txtName.Text == "" ||
                this.txtPhone.Text == "" ||
                this.txtMail.Text == "" ||
                this.txtAddress.Text == "")
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
            this.txtKeyword.Text = "";
        }

        private void isEditable(bool status)
        {
            this.txtName.ReadOnly = !status;
            this.txtPhone.ReadOnly = !status;
            this.txtMail.ReadOnly = !status;
            this.txtAddress.ReadOnly = !status;

            this.nationCbb.Enabled = status;
            this.saveBt.Enabled = status;
            this.cancelBt.Enabled = status;
        }
    }
}
