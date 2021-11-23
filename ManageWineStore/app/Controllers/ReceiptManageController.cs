using ManageWineStore.app.Controllers.ModelControllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Controllers
{
    class ReceiptManageController
    {
        private ImportReceiptController importReceiptController = new ImportReceiptController();
        private ImportReciptDetailController importReciptDetailController = new ImportReciptDetailController();
        private SaleReceiptController saleReceiptController = new SaleReceiptController();
        private SaleReceiptDetailController saleReceiptDetailController = new SaleReceiptDetailController();

        public DataTable getImportReceipts()
        {
            return importReceiptController.findAll(); 
        }

        public DataTable getSaleReceipts()
        {
            return this.saleReceiptController.findAll();
        }

        public DataTable getImportReceiptDetails(string column, object value)
        {
            return this.importReciptDetailController.find(column, value);
        }

        public DataTable getSaleReceiptDetails(string column, object value)
        {
            return this.saleReceiptDetailController.find(column, value);
        }

        public DataTable searchS(string column, object value, string query, string start, string end)
        {
            return this.saleReceiptController.findByConditional(column, value,
                query, start, end);
        }

        public DataTable searchI(string column, object value, string query, string start, string end)
        {
            return this.importReceiptController.findByConditional(column, value,
                query, start, end);
        }
    }
}
