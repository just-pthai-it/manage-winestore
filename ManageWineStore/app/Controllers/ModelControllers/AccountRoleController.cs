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
    class AccountRoleController : AModelController<AccountRoleModel>
    {
        public override void insert(AccountRoleModel accountRoleModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO AccountRole VALUES (@AccountRole_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@AccountRole_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@AccountRole_name"].Value = AccountRoleModel.AccountRoleName;
            //sqlCommand.Parameters["@salary"].Value = AccountRoleModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override void get(AccountRoleModel accountRoleModel)
        {
            throw new NotImplementedException();
        }


        public override void update(AccountRoleModel accountRoleModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(AccountRoleModel accountRoleModel)
        {
            throw new NotImplementedException();
        }
    }
}
