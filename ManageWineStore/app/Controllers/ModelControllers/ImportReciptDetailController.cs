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
    class ImportReciptDetailController : AModelController<ImportReceiptDetailModel>
    {
        public override void insert(ImportReceiptDetailModel importReciptDetailModel)
        {
            string commandText = "INSERT INTO sale_receipt_detail VALUES ( @simport_receipt_id , @merchandise_id , " +
                    "@quanity , @cost );";
            this.executeNonQuery(commandText, new object[] {
                importReciptDetailModel.ImportReceiptId,
                importReciptDetailModel.MerchandiseId,
                importReciptDetailModel.Quantity,
                importReciptDetailModel.Cost,
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

        public override void update(ImportReceiptDetailModel importReciptDetailModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
