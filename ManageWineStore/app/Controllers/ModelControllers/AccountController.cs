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
    class AccountController : AModelController<AccountModel>
    {
        public override void insert(AccountModel accountModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO Account VALUES (@Account_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@Account_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@Account_name"].Value = AccountModel.AccountName;
            //sqlCommand.Parameters["@salary"].Value = AccountModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override void get(AccountModel accountModel)
        {
            throw new NotImplementedException();
        }


        public override void update(AccountModel accountModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(AccountModel accountModel)
        {
            throw new NotImplementedException();
        }
    }
}
