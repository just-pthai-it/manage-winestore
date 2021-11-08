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
    class MerchandiseController : AModelController<MerchandiseModel>
    {
        public override void insert(MerchandiseModel merchandiseModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO merchandise VALUES (@merchandise_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@merchandise_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@merchandise_name"].Value = merchandiseModel.MerchandiseName;
            //sqlCommand.Parameters["@salary"].Value = merchandiseModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override DataTable get(MerchandiseModel merchandiseModel)
        {
            throw new NotImplementedException();
        }


        public override void update(MerchandiseModel merchandiseModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(MerchandiseModel merchandiseModel)
        {
            throw new NotImplementedException();
        }
    }
}
