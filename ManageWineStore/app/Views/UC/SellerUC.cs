using ManageWineStore.app.Controllers;
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

namespace UC
{
    public partial class SellerUC : UserControl
    {
        private SellWineController sellWineController = new SellWineController();
        private int employeeId;
        public SellerUC(int employeeId)
        {
            this.employeeId = employeeId;
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.loadData();
            this.setDGVHeaders();
            DataGridViewRow row = this.dgv.Rows[0];
            numericUpDown1.Maximum = Int32.Parse(row.Cells[5].Value.ToString());
        }
        private void loadData()
        {
            this.dgv.DataSource = this.sellWineController.loadData();
        }

        private void setDGVHeaders()
        {
            this.dgv.Columns["id"].HeaderText = "Mã rượu";
            this.dgv.Columns["wine_name"].HeaderText = "Tên rượu";
            this.dgv.Columns["alcohol_level"].HeaderText = "Nồng độ";
            this.dgv.Columns["price"].HeaderText = "Giá";
            this.dgv.Columns["year_of_manufacture"].HeaderText = "Năm sản xuất";
            this.dgv.Columns["current_quantity"].HeaderText = "Số lượng";
            this.dgv.Columns["merchandise_id"].HeaderText = "Mã lô hàng";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv.SelectedRows[0];
            if (row.Cells[0].Value.ToString() != "")
            {
                this.numericUpDown1.Maximum = Int32.Parse(row.Cells[5].Value.ToString());
            }
            this.numericUpDown1.Value = 0;
        }

        private void okBt_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                return;
            }
            DataGridViewRow row = this.dgv.SelectedRows[0];

            this.dgv.SelectedRows[0].Cells[5].Value = (Int32.Parse(this.dgv.SelectedRows[0].Cells[5].Value.ToString()) -
                                    (int)(numericUpDown1.Value)).ToString();

            bool flag = this.checkIsBought(Int32.Parse(row.Cells[6].Value.ToString()),
                                            row.Cells[1].Value.ToString());
            if (flag)
            {
                this.updateNumericUpDown(Int32.Parse(row.Cells[5].Value.ToString()));
                return;
            }

            double cost = double.Parse(row.Cells[3].Value.ToString()) * (int)numericUpDown1.Value;
            cart.Items.Add(new SaleReceiptDetailModel(
                Int32.Parse(row.Cells[6].Value.ToString()),
                (int)numericUpDown1.Value,
                cost,
                row.Cells[1].Value.ToString()));

            this.updateNumericUpDown(Int32.Parse(row.Cells[5].Value.ToString()));
            this.updateTotalMoney(cost);
        }

        private void updateTotalMoney(double value)
        {
            this.txtTotal.Text = (double.Parse(this.txtTotal.Text) + value).ToString();
        }

        private void updateNumericUpDown(int maximum)
        {
            this.numericUpDown1.Value = 0;
            this.numericUpDown1.Maximum = maximum;
        }
        private bool checkIsBought(int merchandiseId, string wineName)
        {
            int i = 0;
            foreach (SaleReceiptDetailModel item in this.cart.Items)
            {
                if (item.MerchandiseId == merchandiseId &&
                    item.Name == wineName)
                {
                    this.updateOldItem(item, i);
                    return true;
                }
                i++;
            }
            return false;
        }

        private void updateOldItem(SaleReceiptDetailModel item, int index)
        {
            this.updateTotalMoney(-item.Cost);
            item.Cost = (item.Cost / item.Quantity) * (item.Quantity + (int)this.numericUpDown1.Value);
            item.Quantity = item.Quantity + (int)this.numericUpDown1.Value;
            this.cart.Items.Add(item);
            this.cart.Items.RemoveAt(index);
            this.updateTotalMoney(item.Cost);
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            sellWineController.pay(new SaleReceiptModel(
                                                DateTime.Parse(dateTime),
                                                employeeId,
                                                Int32.Parse(this.txtCustomerId.Text),
                                                double.Parse(this.txtTotal.Text)),
                                    this.cart.Items);


            this.reset();
        }

        private void removeBt_Click(object sender, EventArgs e)
        {
            SaleReceiptDetailModel saleReciptDetailModel = (SaleReceiptDetailModel)this.cart.SelectedItem;
            foreach (DataGridViewRow row in this.dgv.Rows)
            {
                if (row.Cells[1].Value.ToString() == saleReciptDetailModel.Name &&
                    row.Cells[6].Value.ToString() == saleReciptDetailModel.MerchandiseId.ToString())
                {
                    row.Cells[5].Value = (Int32.Parse(row.Cells[5].Value.ToString()) +
                                            saleReciptDetailModel.Quantity).ToString();
                    this.cart.Items.RemoveAt(this.cart.SelectedIndex);
                    this.updateTotalMoney(-saleReciptDetailModel.Cost);
                    return;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cart.Items.ToString());
            this.reset();
        }

        private void reset()
        {
            this.txtWIneId.Text = "";
            this.txtWineName.Text = "";
            this.txtMFG.Text = "";
            this.txtTotal.Text = "0";
            this.txtCustomerId.Text = "";
            this.cart.Items.Clear();
            this.setUp();
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            if (this.txtWIneId.Text == "" &&
                this.txtWineName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã rượu hoặc tên rượu để tìm kiếm");
                return;
            }

            foreach (DataGridViewRow row in this.dgv.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }

                if (this.filter(row.Cells[0].Value.ToString(),
                                row.Cells[1].Value.ToString(),
                                row.Cells[4].Value.ToString()))
                {
                    this.dgv.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy sản phẩm nào có thông tin trùng khớp");
        }

        private bool filter(string wineId, string wineName, string mfg)
        {
            if (this.txtWIneId.Text != "" &&
                this.txtWineName.Text != "")
            {
                if (this.txtWIneId.Text == wineId &&
                    this.txtWineName.Text.IndexOf(wineName) >= 0)
                {
                    if (this.txtMFG.Text != "")
                    {
                        if (this.txtMFG.Text == mfg)
                        {
                            return true;
                        }

                        return false;
                    }

                    return true;
                }

                return false;
            }
            else
            {
                if (this.txtWIneId.Text == wineId ||
                    this.txtWineName.Text.IndexOf(wineName) >= 0)
                {
                    if (this.txtMFG.Text != "")
                    {
                        if (this.txtMFG.Text == mfg)
                        {
                            return true;
                        }

                        return false;
                    }

                    return true;
                }

                return false;
            }
        }
    }
}
