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
using System.Windows.Forms;

namespace ManageWineStore.app.Controllers.ModelControllers
{
    class SaleReceiptController : AModelController<SaleReceiptModel>
    {
        public int insertGetId(SaleReceiptModel saleReciptModel)
        {
            string commandText = "INSERT INTO sale_receipt output INSERTED.id VALUES ( @create_at , @employee_id , " +
                                "@customer_id , @total_money );";
            return (int)this.ExecuteScalar(commandText, new object[] {
                saleReciptModel.CreateAt,
                saleReciptModel.EmployeeId,
                saleReciptModel.CustomerId,
                saleReciptModel.TotalMoney
            });
        }

        public override void insert(SaleReceiptModel saleReciptModel)
        {
            string commandText = "INSERT INTO sale_receipt VALUES ( @create_at , @employee_id , " +
                                "@customer_id , @total_money );";
            this.executeNonQuery(commandText, new object[] {
                saleReciptModel.CreateAt,
                saleReciptModel.EmployeeId,
                saleReciptModel.CustomerId,
                saleReciptModel.CustomerId,
                saleReciptModel.TotalMoney
            });
        }

        public DataTable findProc(string id)
        {
            string commandText = "EXEC sale_receipt_export @id ;";
            return this.executeQuery(commandText, new object[] { id });
        }

        public override DataTable find(string column, object value)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            string commandText = "SELECT * FROM sale_receipt_custom ;";
            return this.executeQuery(commandText);
        }

        public DataTable findByConditional(string column, object value, string query,
                                            string start, string end)
        {
            string commandText = "SELECT * FROM sale_receipt_custom WHERE " + column + " LIKE @" + column + query;
            return this.executeQuery(commandText, new object[]
            {
                "%" + value + "%" ,
                start,
                end,
            });
        }

        public override void update(SaleReceiptModel saleReciptModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            string commandText = "DELETE FROM sale_receipt WHERE id = @id ;";
            this.executeQuery(commandText, new object[] { id });
        }

        public DataTable getRevenue(string commandText, object[] conditionals)
        {
            return this.executeQuery(commandText, conditionals);
        }
    }
}
