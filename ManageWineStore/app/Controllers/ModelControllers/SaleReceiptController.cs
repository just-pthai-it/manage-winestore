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
    class SaleReceiptController : AModelController<SaleReceiptModel>
    {
        public int insertGetId (SaleReceiptModel saleReciptModel)
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

        public override DataTable find(string id)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public override void update(SaleReceiptModel saleReciptModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
