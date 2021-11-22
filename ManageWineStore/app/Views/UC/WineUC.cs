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
    public partial class WineUC : UserControl
    {
        private WineManageController wineManageController = new WineManageController();
        public WineUC()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.loadData();
            this.setDGVHeaders();
            this.loadKeyCbbData();
        }
        private void loadData()
        {
            this.dgv.DataSource = wineManageController.getWines();
        }

        private void setDGVHeaders()
        {
            this.dgv.Columns["id"].HeaderText = "Mã rượu";
            this.dgv.Columns["wine_name"].HeaderText = "Tên rượu";
            this.dgv.Columns["alcohol_level"].HeaderText = "Độ rượu";
            this.dgv.Columns["image"].Visible = false;
        }

        private void loadKeyCbbData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("column");
            dataTable.Columns.Add("text");

            DataRow row = dataTable.NewRow();
            row["column"] = "id";
            row["text"] = "Mã rượu";
            DataRow row2 = dataTable.NewRow();
            row2["column"] = "wine_name";
            row2["text"] = "Tên rượu";
            DataRow row3 = dataTable.NewRow();
            row3["column"] = "alcohol_level";
            row3["text"] = "Độ rượu";

            dataTable.Rows.Add(row);
            dataTable.Rows.Add(row2);
            dataTable.Rows.Add(row3);

            this.keyCbb.DisplayMember = "text";
            this.keyCbb.ValueMember = "column";
            this.keyCbb.DataSource = dataTable;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            this.reset();
            this.isEditable(true);
            this.updateBt.Enabled = false;
            this.deleteBt.Enabled = false;
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgv.SelectedRows[0];
            if (row.Cells[0] == null)
            {
                return;
            }

            this.wineManageController.removeWine(row.Cells[0].Value.ToString());
            this.loadData();
        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            this.loadData();
            this.reset();
            this.isEditable(false);
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgv.SelectedRows[0];
            if (row.Cells[0] == null)
            {
                return;
            }

            this.isEditable(true);
            this.addBt.Enabled = false;
            this.deleteBt.Enabled = false;

            this.txtId.Text = row.Cells[0].Value.ToString();
            this.txtName.Text = row.Cells[1].Value.ToString();
            this.txtAlcoholLevel.Text = row.Cells[2].Value.ToString();
            this.pictureBox.Image = ImageHandler.bytesToImage((byte[])row.Cells[3].Value);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.reset();
            this.isEditable(false);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!this.validate())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            WineModel wineModel = null;
            try
            {
                wineModel = new WineModel(
                this.txtId.Text == "" ? null : (int?)int.Parse(this.txtId.Text),
                this.txtName.Text,
                int.Parse(this.txtAlcoholLevel.Text),
                ImageHandler.imageToBytes(this.pictureBox.Image));
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return;
            }

            if (this.addBt.Enabled == true)
            {
                this.wineManageController.createWine(wineModel);
            }
            else
            {
                this.wineManageController.updateWine(wineModel);
            }
            this.loadData();
            this.reset();
            this.isEditable(false);
        }

        private void reset()
        {
            this.txtId.Text = "";
            this.txtName.Text = "";
            this.txtAlcoholLevel.Text = "";
            this.txtKeyword.Text = "";

            this.addBt.Enabled = true;
            this.updateBt.Enabled = true;
            this.deleteBt.Enabled = true;
            this.pictureBox.Image = null;
        }

        private bool validate()
        {
            if (this.txtName.Text == "" ||
                this.txtAlcoholLevel.Text == "" ||
                this.pictureBox.Image == null)
            {
                return false;
            }

            return true;
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            if (this.txtKeyword.Text == "")
            {
                return;
            }

            this.dgv.DataSource = this.wineManageController.search(this.keyCbb.SelectedValue.ToString(),
                                                                    this.txtKeyword.Text);
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
            this.pictureBox.Enabled = status;

            this.saveBt.Enabled = status;
            this.cancelBt.Enabled = status;
            this.selectImgBt.Enabled = status;
        }
    }
}
