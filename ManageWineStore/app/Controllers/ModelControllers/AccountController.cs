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
            string commandText = "INSERT INTO Account VALUES ( @username , @password , @user_id );";
            this.executeNonQuery(commandText, new object[] {
                accountModel.Username, accountModel.Password, accountModel.UserId
            });
        }

        public DataTable find(string username, string password)
        {
            string commandText = "SELECT * FROM Account WHERE username = @username AND " +
                                "password = @password ;";
            return this.executeQuery(commandText, new object[] { username, password });
        }
        public override DataTable get(AccountModel accountModel)
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
