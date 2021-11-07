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
        public override void insert(SaleReciptModel saleReciptModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO saleRecipt VALUES (@saleRecipt_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@saleRecipt_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@saleRecipt_name"].Value = saleReciptModel.SaleReciptName;
            //sqlCommand.Parameters["@salary"].Value = saleReciptModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override void get(SaleReciptModel saleReciptModel)
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
