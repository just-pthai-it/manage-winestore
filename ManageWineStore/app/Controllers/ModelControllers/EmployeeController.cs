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
    class EmployeeController : AModelController<EmployeeModel>
    {
        public override void insert(EmployeeModel employeeModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO employee VALUES (@employee_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@employee_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@employee_name"].Value = employeeModel.EmployeeName;
            //sqlCommand.Parameters["@salary"].Value = employeeModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public DataTable find(string account_id)
        {
            string commandText = "SELECT * FROM employee WHERE account_id = @account_id ;";
            return this.executeQuery(commandText, new object[] { account_id });
        }
        public override DataTable get(EmployeeModel employeeModel)
        {
            throw new NotImplementedException();
        }

        public override void update(EmployeeModel employeeModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(EmployeeModel employeeModel)
        {
            throw new NotImplementedException();
        }
    }
}
