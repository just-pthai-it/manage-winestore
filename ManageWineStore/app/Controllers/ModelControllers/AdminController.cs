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
    class AdminController : AModelController<AdminModel>
    {
        public override void insert(AdminModel adminModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO admin VALUES (@admin_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@admin_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@admin_name"].Value = adminModel.AdminName;
            //sqlCommand.Parameters["@salary"].Value = adminModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public DataTable find(string account_id)
        {
            string commandText = "SELECT * FROM admin WHERE account_id = @account_id ;";
            return this.executeQuery(commandText, new object[] { account_id });
        }
        public override DataTable get(AdminModel adminModel)
        {
            throw new NotImplementedException();
        }

        public override void update(AdminModel adminModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(AdminModel adminModel)
        {
            throw new NotImplementedException();
        }
    }
}
