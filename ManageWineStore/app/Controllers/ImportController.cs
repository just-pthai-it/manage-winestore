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
    class ImportController
    {
        private MerchandiseController merchandiseController = new MerchandiseController();
        private ImportReceiptController importReceiptController = new ImportReceiptController();
        private ImportReciptDetailController ImportReciptDetailController = new ImportReciptDetailController();
        private WineController wineController = new WineController();

        public DataTable getWines()
        {
            return wineController.findAll();
        }

        public int comfirm(ImportReceiptModel importReceiptModel,
                            ListBox.ObjectCollection items,
                            List<MerchandiseModel> merchandises)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    int irc_id = importReceiptController.insertGetId(importReceiptModel);
                    int i = 0;
                    foreach (var merchandise in merchandises)
                    {
                        int m_id = merchandiseController.insertGetId(merchandise);
                        ImportReceiptDetailModel importReceiptDetailModel1 = (ImportReceiptDetailModel)items[i];
                        importReceiptDetailModel1.ImportReceiptId = irc_id;
                        importReceiptDetailModel1.MerchandiseId = m_id;
                        MessageBox.Show(irc_id.ToString());
                        ImportReciptDetailController.insert(importReceiptDetailModel1);
                        i++;
                    }
                    scope.Complete();
                    MessageBox.Show("Nhập hàng thành công");
                    return irc_id;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!\n Không thể thực hiện được thao tác");
                return -1;
            }
        }

        public DataTable getExportIData(string id)
        {
            return importReceiptController.findProc(id);
        }
    }
}
