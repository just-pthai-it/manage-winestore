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
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO saleReciptDetail VALUES (@saleReciptDetail_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@saleReciptDetail_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@saleReciptDetail_name"].Value = saleReciptDetailModel.SaleReciptDetailName;
            //sqlCommand.Parameters["@salary"].Value = saleReciptDetailModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override void get(SaleReciptDetailModel saleReciptDetailModel)
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
