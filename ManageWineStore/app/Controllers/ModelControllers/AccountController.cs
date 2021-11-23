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
            string commandText = "INSERT INTO account VALUES ( @username , @password , @role_id );";
            this.executeNonQuery(commandText, new object[] {
                accountModel.Username, accountModel.Password, accountModel.RoleId
            });
        }

        public DataTable findByUsernameAndPassword(string username, string password)
        {
            string commandText = "SELECT * FROM account WHERE username = @username AND " +
                                "password = @password ;";
            return this.executeQuery(commandText, new object[] { username, password });
        }

        public DataTable findByConditional(string column, Object value)
        {
            string commandText = "SELECT * FROM account_info WHERE " + column + " LIKE @" + column + " ;";
            return this.executeQuery(commandText, new object[] { "%" + value + "%" });
        }

        public override DataTable find(string column, object value)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            string commandText = "SELECT * FROM account_info ;";
            return this.executeQuery(commandText);
        }

        public override void update(AccountModel accountModel)
        {
            string commandText = "UPDATE account SET password = @password , role_id = @role_id WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[]
            {
                accountModel.Password,
                accountModel.RoleId,
                accountModel.Id,
            });
        }

        public override void delete(string id)
        {
            string commandText = "DELETE FROM account WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[] { id });
        }
    }
}
