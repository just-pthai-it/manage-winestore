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
    class RoleController : AModelController<RoleModel>
    {
        public override void insert(RoleModel roleModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO role VALUES (@role_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@role_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@role_name"].Value = roleModel.RoleName;
            //sqlCommand.Parameters["@salary"].Value = roleModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override void get(RoleModel roleModel)
        {
            throw new NotImplementedException();
        }


        public override void update(RoleModel roleModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(RoleModel roleModel)
        {
            throw new NotImplementedException();
        }
    }
}
