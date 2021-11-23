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
    public partial class StorageUC : UserControl
    {
        private StorageController storageController = new StorageController();
        public StorageUC()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.loadKeyCbbData();
            this.loadWineCbbData();
            this.loadData();
            this.setDGVHeaders();
        }

        private void loadKeyCbbData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("column");
            dataTable.Columns.Add("text");

            DataRow row = dataTable.NewRow();
            row["column"] = "wine_name";
            row["text"] = "Tên rượu";
            DataRow row2 = dataTable.NewRow();
            row2["column"] = "price";
            row2["text"] = "GIá";
            DataRow row3 = dataTable.NewRow();
            row3["column"] = "year_of_manufacture";
            row3["text"] = "Năm SX";
            DataRow row4 = dataTable.NewRow();
            row4["column"] = "current_quantitty";
            row4["text"] = "Số lượng";


            dataTable.Rows.Add(row);
            dataTable.Rows.Add(row2);
            dataTable.Rows.Add(row3);
            dataTable.Rows.Add(row4);

            this.keyCbb.DisplayMember = "text";
            this.keyCbb.ValueMember = "column";
            this.keyCbb.DataSource = dataTable;
        }

        private void loadWineCbbData()
        {
            this.wineCbb.DisplayMember = "name";
            this.wineCbb.ValueMember = "id";
            this.wineCbb.DataSource = storageController.getWines();
        }

        private void loadData()
        {
            this.dgv.DataSource = this.storageController.getMerchandises();
        }

        private void setDGVHeaders()
        {
            this.dgv.Columns["merchandise_id"].HeaderText = "Mã HH";
            this.dgv.Columns["wine_name"].HeaderText = "Tên rượu";
            this.dgv.Columns["price"].HeaderText = "Giá niêm yết";
            this.dgv.Columns["year_of_manufacture"].HeaderText = "Năm SX";
            this.dgv.Columns["current_quantity"].HeaderText = "Số lượng";
            this.dgv.Columns["create_at"].HeaderText = "Thời gian nhập";
            this.dgv.Columns["image"].Visible = false;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            this.updateBt.Enabled = false;
            //this.deleteBt.Enabled = false;
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

            //this.deleteBt.Enabled = false;
            this.isEditable(true);

            this.txtId.Text = row.Cells[0].Value.ToString();
            this.txtPrice.Text = row.Cells[2].Value.ToString();
            this.txtFCM.Text = row.Cells[3].Value.ToString();
            this.txtQuantity.Text = row.Cells[4].Value.ToString();

            this.wineCbb.Text = row.Cells[1].Value.ToString();
            this.pictureBox.Image = ImageHandler.bytesToImage((byte[])row.Cells[6].Value);
        }

        //private void deleteBt_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu?",
        //                    "Xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.No)
        //    {
        //        return;
        //    }

        //    DataGridViewRow row = this.dgv.SelectedRows[0];
        //    if (row.Cells[0] == null)
        //    {
        //        return;
        //    }

        //    this.storageController.removeMerchandise(row.Cells[0].Value.ToString());
        //    this.loadData();
        //}

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

            MerchandiseModel merchandiseModel = null;
            try
            {
                merchandiseModel = new MerchandiseModel(
                this.txtId.Text == "" ? null : (int?)int.Parse(this.txtId.Text),
                int.Parse(this.wineCbb.SelectedValue.ToString()),
                this.txtFCM.Text,
                int.Parse(this.txtQuantity.Text),
                int.Parse(this.txtPrice.Text));
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return;
            }

            this.storageController.updateMerchandise(merchandiseModel);

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

            this.dgv.DataSource = this.storageController.search(this.keyCbb.SelectedValue.ToString(),
                                                                    this.txtKeyword.Text);
        }

        private bool validate()
        {
            if (this.txtFCM.Text == "" ||
                this.txtPrice.Text == "" ||
                this.txtQuantity.Text == "" ||
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
            //this.deleteBt.Enabled = true;
        }

        private void clear()
        {
            this.txtId.Text = "";
            this.txtFCM.Text = "";
            this.txtPrice.Text = "";
            this.txtQuantity.Text = "";
            this.txtKeyword.Text = "";
            this.pictureBox.Image = null;
        }

        private void isEditable(bool status)
        {
            this.txtId.Enabled = status;
            this.wineCbb.Enabled = status;
            this.txtFCM.Enabled = status;
            this.txtPrice.Enabled = status;
            this.txtQuantity.Enabled = status;

            this.saveBt.Enabled = status;
            this.cancelBt.Enabled = status;
        }
    }
}
