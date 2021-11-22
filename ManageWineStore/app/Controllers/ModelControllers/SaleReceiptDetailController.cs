using ManageWineStore.app.Controllers.ModelControllers.Abastract;
using ManageWineStore.app.Models;
using ManageWineStore.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Controllers.ModelControllers
{
    class SaleReceiptDetailController : AModelController<SaleReceiptDetailModel>
    {
        public override void insert(SaleReceiptDetailModel saleReciptDetailModel)
        {
            string commandText = "INSERT INTO sale_receipt_detail VALUES ( @sale_receipt_id , @merchandise_id , " +
                                "@quanity , @cost );";
            this.executeNonQuery(commandText, new object[] 
            {
                saleReciptDetailModel.SaleReceiptId, 
                saleReciptDetailModel.MerchandiseId, 
                saleReciptDetailModel.Quantity, 
                saleReciptDetailModel.Cost
            });
        }

        public override DataTable find(string id)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public override void update(SaleReceiptDetailModel saleReciptDetailModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
