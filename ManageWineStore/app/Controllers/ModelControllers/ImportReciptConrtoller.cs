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
    class ImportReceiptController : AModelController<ImportReceiptModel>
    {
        public int insertGetId(ImportReceiptModel importReciptModel)
        {
            string commandText = "INSERT INTO import_receipt output INSERTED.id VALUES ( @create_at , @employee_id , " +
                                "@supplier_id , @total_money );";
            return (int)this.ExecuteScalar(commandText, new object[] {
                importReciptModel.CreateAt,
                importReciptModel.EmployeeId,
                importReciptModel.SupplierId,
                importReciptModel.TotalMoney,
            });
        }

        public override void insert(ImportReceiptModel importReciptModel)
        {

        }

        public DataTable findProc(string id)
        {
            string commandText = "EXEC import_receipt_export @id ;";
            return this.executeQuery(commandText, new object[] { id });
        }

        public override DataTable find(string column, object value)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            string commandText = "SELECT * FROM import_receipt_custom ;";
            return this.executeQuery(commandText);
        }

        public DataTable findByConditional(string column, object value, string query,
                                    string start, string end)
        {
            string commandText = "SELECT * FROM import_receipt_custom WHERE " + column + " LIKE @" + column + query;
            return this.executeQuery(commandText, new object[]
            {
                "%" + value + "%" ,
                start,
                end,
            });
        }

        public override void update(ImportReceiptModel importReciptModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            string commandText = "DELETE FROM import_receipt WHERE id = @id ;";
            this.executeQuery(commandText, new object[] { id });
        }
    }
}
