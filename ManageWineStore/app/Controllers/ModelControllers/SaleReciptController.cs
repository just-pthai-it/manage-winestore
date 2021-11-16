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
    class SaleReciptController : AModelController<SaleReciptModel>
    {
        public int insertGetId (SaleReciptModel saleReciptModel)
        {
            string commandText = "INSERT INTO sale_recipt output INSERTED.id VALUES ( @create_at , @employee_id , " +
                                "@customer_id , @total_money );";
            return (int)this.ExecuteScalar(commandText, new object[] {
                saleReciptModel.CreateAt, saleReciptModel.EmployeeId,
                saleReciptModel.CustomerId, saleReciptModel.TotalMoney
            });
        }

        public override void insert(SaleReciptModel saleReciptModel)
        {
            string commandText = "INSERT INTO sale_recipt VALUES ( @create_at , @employee_id , " +
                                "@customer_id , @total_money );";
            this.executeNonQuery(commandText, new object[] {
                saleReciptModel.CreateAt, saleReciptModel.EmployeeId, saleReciptModel.CustomerId,
                saleReciptModel.CustomerId, saleReciptModel.TotalMoney
            });
        }

        public override DataTable get(SaleReciptModel saleReciptModel)
        {
            throw new NotImplementedException();
        }


        public override void update(SaleReciptModel saleReciptModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(SaleReciptModel saleReciptModel)
        {
            throw new NotImplementedException();
        }
    }
}
