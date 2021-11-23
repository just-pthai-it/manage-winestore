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
    public partial class ImportUC : UserControl
    {
        private ImportController importController = new ImportController();
        private List<MerchandiseModel> merchandises = new List<MerchandiseModel>();
        private int employeeId = -1;
        public ImportUC(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.loadWineCbbData();
        }

        private void loadWineCbbData()
        {
            this.wineCbb.DisplayMember = "wine_name";
            this.wineCbb.ValueMember = "id";
            this.wineCbb.DataSource = this.importController.getWines();
        }

        private bool validate()
        {
            if (this.txtSupplierId.Text == "" ||
                this.txtCost.Text == "" ||
                this.txtPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }

            if (!double.TryParse(this.txtCost.Text, out double a) ||
                !double.TryParse(this.txtPrice.Text, out double b))
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return false;
            }

            return true;
        }

        private void comfirmBt_Click(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.importController.comfirm(new ImportReceiptModel(
                                                null,
                                                DateTime.Parse(dateTime),
                                                this.employeeId,
                                                Int32.Parse(this.txtSupplierId.Text),
                                                double.Parse(this.txtTotal.Text)),
                                        this.cart.Items,
                                        merchandises);

            this.reset();
            this.cart.Items.Clear();
            this.merchandises.Clear();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void removeBt_Click(object sender, EventArgs e)
        {
            ImportReceiptDetailModel importReceiptDetailModel = (ImportReceiptDetailModel)this.cart.SelectedItem;
            if (importReceiptDetailModel == null)
            {
                return;
            }

            ImportReceiptDetailModel importReceiptDetailModel1 = (ImportReceiptDetailModel)this.cart.SelectedItem;
            this.updateTotal(-importReceiptDetailModel1.Cost);

            this.merchandises.RemoveAt(this.cart.SelectedIndex);
            this.cart.Items.RemoveAt(this.cart.SelectedIndex);

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!this.validate())
            {
                return;
            }

            this.cart.Items.Add(new ImportReceiptDetailModel(
                                                    null,
                                                    null,
                                                    null,
                                                    (int)this.quantityNumericUD.Value,
                                                    double.Parse(this.txtCost.Text),
                                                    wineCbb.Text,
                                                    mfgNumericUD.Value.ToString()));


            this.merchandises.Add(new MerchandiseModel(
                                                null,
                                                (int)this.wineCbb.SelectedValue,
                                                this.mfgNumericUD.Value.ToString(),
                                                (int)this.quantityNumericUD.Value,
                                                double.Parse(this.txtPrice.Text)));

            this.updateTotal(double.Parse(this.txtCost.Text));
            this.txtCost.Text = "";
            this.txtPrice.Text = "";
        }

        private void updateTotal(double value)
        {
            this.txtTotal.Text = (double.Parse(this.txtTotal.Text) + value).ToString();
        }

        private void abortBt_Click(object sender, EventArgs e)
        {
            this.reset();
            this.cart.Items.Clear();
            this.merchandises.Clear();
        }

        private void reset()
        {
            this.txtSupplierId.Text = "";
            this.txtCost.Text = "";
            this.txtPrice.Text = "";
        }
    }
}
