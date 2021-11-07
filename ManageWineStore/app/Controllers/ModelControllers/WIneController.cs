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
    class WineController : AModelController<WineModel>
    {
        public override void insert(WineModel wineModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO wine VALUES (@wine_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@wine_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@wine_name"].Value = wineModel.WineName;
            //sqlCommand.Parameters["@salary"].Value = wineModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override void get(WineModel wineModel)
        {
            throw new NotImplementedException();
        }


        public override void update(WineModel wineModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(WineModel wineModel)
        {
            throw new NotImplementedException();
        }
    }
}
