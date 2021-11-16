using ManageWineStore.app.Controllers.ModelControllers;
using ManageWineStore.app.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageWineStore.app.Controllers
{
    class SellWineController
    {
        private WineController wineController = new WineController();
        private SaleReciptController saleReciptController = new SaleReciptController();
        private SaleReciptDetailController saleReciptDetailController = new SaleReciptDetailController();

        public DataTable loadData()
        {
            return this.wineController.findAll();
        }

        public void pay(SaleReciptModel saleReciptModel, ListBox.ObjectCollection items)
        {
            int id = saleReciptController.insertGetId(saleReciptModel);
            foreach (SaleReciptDetailModel item in items)
            {
                item.SaleReciptId = id;
                saleReciptDetailController.insert(item);
            }
        }
    }
}
