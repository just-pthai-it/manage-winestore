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
    class SaleReciptDetailController : AModelController<SaleReciptDetailModel>
    {
        public override void insert(SaleReciptDetailModel saleReciptDetailModel)
        {
            string commandText = "INSERT INTO sale_recipt_detail VALUES ( @sale_recipt_id , @merchandise_id , " +
                                "@quanity , @cost );";
            this.executeNonQuery(commandText, new object[] {
                saleReciptDetailModel.SaleReciptId, saleReciptDetailModel.MerchandiseId, 
                saleReciptDetailModel.Quantity, saleReciptDetailModel.Cost
            });
        }

        public override DataTable get(SaleReciptDetailModel saleReciptDetailModel)
        {
            throw new NotImplementedException();
        }


        public override void update(SaleReciptDetailModel saleReciptDetailModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(SaleReciptDetailModel saleReciptDetailModel)
        {
            throw new NotImplementedException();
        }
    }
}
