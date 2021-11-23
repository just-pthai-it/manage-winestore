using ManageWineStore.app.BussinessClasses;
using ManageWineStore.app.Controllers;
using ManageWineStore.export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageWineStore.app.Views.UC
{
    public partial class ReceiptUC : UserControl
    {
        private ReceiptManageController receiptManageController = new ReceiptManageController();

        public ReceiptUC()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.loadData();
            this.setDGVHeaders();
            this.loadKeyICbbData();
            this.loadKeySCbbData();
        }

        private void loadKeySCbbData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("column");
            dataTable.Columns.Add("text");

            DataRow row = dataTable.NewRow();
            row["column"] = "id";
            row["text"] = "Mã HĐB";
            DataRow row2 = dataTable.NewRow();
            row2["column"] = "employee_name";
            row2["text"] = "Nhân viên tạo HĐ";
            DataRow row3 = dataTable.NewRow();
            row3["column"] = "customer_name";
            row3["text"] = "Khách hàng";

            dataTable.Rows.Add(row);
            dataTable.Rows.Add(row2);
            dataTable.Rows.Add(row3);

            this.keySCbb.DisplayMember = "text";
            this.keySCbb.ValueMember = "column";
            this.keySCbb.DataSource = dataTable;
        }

        private void loadKeyICbbData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("column");
            dataTable.Columns.Add("text");

            DataRow row = dataTable.NewRow();
            row["column"] = "id";
            row["text"] = "Mã HĐN";
            DataRow row2 = dataTable.NewRow();
            row2["column"] = "employee_name";
            row2["text"] = "Nhân viên tạo HĐ";
            DataRow row3 = dataTable.NewRow();
            row3["column"] = "supplier_name";
            row3["text"] = "Nhà cung cấp";

            dataTable.Rows.Add(row);
            dataTable.Rows.Add(row2);
            dataTable.Rows.Add(row3);

            this.keyICbb.DisplayMember = "text";
            this.keyICbb.ValueMember = "column";
            this.keyICbb.DataSource = dataTable;
        }
        private void loadData()
        {
            this.loadSaleReceiptsData();
            this.loadImportReceiptsData();
        }

        private void loadSaleReceiptsData()
        {
            this.saleReceiptDgv.DataSource = receiptManageController.getSaleReceipts();
        }

        private void loadImportReceiptsData()
        {
            this.importReceiptDgv.DataSource = receiptManageController.getImportReceipts();
        }

        private void setDGVHeaders()
        {
            this.setSDGVHeaders();
            this.setIDGVHeaders();
        }

        private void setSDGVHeaders()
        {
            this.saleReceiptDgv.Columns["id"].HeaderText = "Mã HĐB";
            this.saleReceiptDgv.Columns["create_at"].HeaderText = "Ngày tạo HĐ";
            this.saleReceiptDgv.Columns["employee_name"].HeaderText = "Nhân viên tạo HĐ";
            this.saleReceiptDgv.Columns["customer_name"].HeaderText = "Tên khách hàng";
            this.saleReceiptDgv.Columns["total_money"].HeaderText = "Tổng tiền";
        }

        private void setIDGVHeaders()
        {
            this.importReceiptDgv.Columns["id"].HeaderText = "Mã HĐN";
            this.importReceiptDgv.Columns["create_at"].HeaderText = "Ngày tạo HĐ";
            this.importReceiptDgv.Columns["employee_name"].HeaderText = "Nhân viên tạo HĐ";
            this.importReceiptDgv.Columns["supplier_name"].HeaderText = "Tên NCC";
            this.importReceiptDgv.Columns["total_money"].HeaderText = "Tổng tiền";
        }

        private void saleReceiptDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.loadSaleReceiptDetailsData(this.saleReceiptDgv.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void importReceiptDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.loadImportReceiptDetailsData(this.importReceiptDgv.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void loadSaleReceiptDetailsData(string id)
        {
            this.saleReceiptDetailDgv.DataSource = receiptManageController.getSaleReceiptDetails("sale_receipt_id", id);
            this.setSDDGVHeaders();
        }

        private void loadImportReceiptDetailsData(string id)
        {
            this.importReceiptDetailDgv.DataSource = receiptManageController.getImportReceiptDetails("import_receipt_id", id);
            this.setIDDGVHeaders();
        }

        private void setSDDGVHeaders()
        {
            this.saleReceiptDetailDgv.Columns["id"].HeaderText = "Mã CTHĐB";
            this.saleReceiptDetailDgv.Columns["wine_name"].HeaderText = "Tên rượu";
            this.saleReceiptDetailDgv.Columns["price_per_product"].HeaderText = "Giá niêm yết";
            this.saleReceiptDetailDgv.Columns["year_of_manufacture"].HeaderText = "Năm sản xuất";
            this.saleReceiptDetailDgv.Columns["quantity"].HeaderText = "Số lượng";
            this.saleReceiptDetailDgv.Columns["cost"].HeaderText = "Thành tiền";
        }

        private void setIDDGVHeaders()
        {
            this.importReceiptDetailDgv.Columns["id"].HeaderText = "Mã CTHĐN";
            this.importReceiptDetailDgv.Columns["wine_name"].HeaderText = "Tên rượu";
            this.importReceiptDetailDgv.Columns["price_per_product"].HeaderText = "Giá niêm yết";
            this.importReceiptDetailDgv.Columns["year_of_manufacture"].HeaderText = "Năm sản xuất";
            this.importReceiptDetailDgv.Columns["quantity"].HeaderText = "Số lượng";
            this.importReceiptDetailDgv.Columns["cost"].HeaderText = "Thành tiền";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            this.startIDtp.Enabled = !this.startIDtp.Enabled;
            this.endIDtp.Enabled = !this.endIDtp.Enabled;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.startSDtp.Enabled = !this.startSDtp.Enabled;
            this.endSDtp.Enabled = !this.endSDtp.Enabled;
        }

        private void searchSBt_Click(object sender, EventArgs e)
        {
            if (this.txtSKeyword.Text == "" &&
                !this.startSDtp.Enabled)
            {
                return;
            }

            string query = this.startSDtp.Enabled ? " AND create_at >= @start AND create_at <= @end" : "";
            this.saleReceiptDgv.DataSource = this.receiptManageController.searchS(
                this.keySCbb.SelectedValue.ToString(),
                this.txtSKeyword.Text,
                query,
                Helper.formatDate(this.startSDtp.Text),
                Helper.formatDate(this.endSDtp.Text));
        }

        private void searchIBt_Click(object sender, EventArgs e)
        {
            if (this.txtIKeyword.Text == "" &&
                !this.startIDtp.Enabled)
            {
                return;
            }

            string query = this.startIDtp.Enabled ? " AND create_at >= @start AND create_at <= @end" : "";
            this.importReceiptDgv.DataSource = this.receiptManageController.searchI(
                this.keyICbb.SelectedValue.ToString(),
                this.txtIKeyword.Text,
                query,
                Helper.formatDate(this.startIDtp.Text),
                Helper.formatDate(this.endIDtp.Text));
        }

        private void refreshSBt_Click(object sender, EventArgs e)
        {
            this.loadSaleReceiptsData();
        }

        private void refreshIBt_Click(object sender, EventArgs e)
        {
            this.loadImportReceiptsData();
        }

        private void exportIFileBt_Click(object sender, EventArgs e)
        {
            ReceiptExport.Export(receiptManageController.getExportIData(
                    this.importReceiptDgv.SelectedRows[0].Cells[0].Value.ToString()), "sheet", "Hóa đơn nhập", "Tên NCC:");
        }

        private void exportSFileBt_Click(object sender, EventArgs e)
        {

            ReceiptExport.Export(receiptManageController.getExportSData(
                    this.saleReceiptDgv.SelectedRows[0].Cells[0].Value.ToString()), "sheet", "Hóa đơn bán", "Họ tên khách hàng:");
        }
    }
}
