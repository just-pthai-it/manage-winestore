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
            string commandText = "INSERT INTO import_receipt_detail VALUES ( @import_receipt_id , @merchandise_id , " +
                    "@quanity , @cost );";
            this.executeNonQuery(commandText, new object[] {
                importReciptDetailModel.ImportReceiptId,
                importReciptDetailModel.MerchandiseId,
                importReciptDetailModel.Quantity,
                importReciptDetailModel.Cost,
            });
        }

        public override DataTable find(string column, object value)
        {
            string commandText = "SELECT id, wine_name, price_per_product, year_of_manufacture, " +
                                "quantity, cost FROM import_receipt_detail_custom " +
                                "WHERE " + column + " = @" + column + " ;";
            return this.executeQuery(commandText, new object[] { value });
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

        public void deleteBySingleConditional(string column, Object value)
        {
            string commandText = "DELETE FROM import_receipt_detail WHERE " + column + " = @" + column + " ;";
            this.executeNonQuery(commandText, new object[] { value });
        }
    }
}
