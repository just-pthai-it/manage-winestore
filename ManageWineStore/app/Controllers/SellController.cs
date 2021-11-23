using ManageWineStore.app.Controllers.ModelControllers;
using ManageWineStore.app.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ManageWineStore.app.Controllers
{
    class SellController
    {
        private MerchandiseController merchandiseController = new MerchandiseController();
        private SaleReceiptController saleReceiptController = new SaleReceiptController();
        private SaleReceiptDetailController saleReceiptDetailController = new SaleReceiptDetailController();

        public DataTable loadData()
        {
            return this.merchandiseController.findAll2();
        }

        public int pay(SaleReceiptModel saleReciptModel, ListBox.ObjectCollection items)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    int id = saleReceiptController.insertGetId(saleReciptModel);
                    foreach (SaleReceiptDetailModel item in items)
                    {
                        item.SaleReceiptId = id;
                        saleReceiptDetailController.insert(item);
                    }
                    scope.Complete();
                    MessageBox.Show("Thanh toán thành công");
                    return id;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!\n Không thể thực hiện được thao tác");
                return -1;
            }
        }

        public DataTable getExportSData(string id)
        {
            return saleReceiptController.findProc(id);
        }
    }
}
