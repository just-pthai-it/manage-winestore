﻿using ManageWineStore.app.Controllers.ModelControllers;
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
    class SellWineController
    {
        private WineController wineController = new WineController();
        private SaleReceiptController saleReciptController = new SaleReceiptController();
        private SaleReceiptDetailController saleReciptDetailController = new SaleReceiptDetailController();

        public DataTable loadData()
        {
            return this.wineController.findAll();
        }

        public void pay(SaleReceiptModel saleReciptModel, ListBox.ObjectCollection items)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                int id = saleReciptController.insertGetId(saleReciptModel);
                foreach (SaleReceiptDetailModel item in items)
                {
                    item.SaleReceiptId = id;
                    saleReciptDetailController.insert(item);
                }
                scope.Complete();
            }
        }
    }
}
