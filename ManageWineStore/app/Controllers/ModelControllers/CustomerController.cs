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
    class CustomerController : AModelController<CustomerModel>
    {
        public override void insert(CustomerModel customerModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO Customer VALUES (@Customer_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@Customer_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@Customer_name"].Value = CustomerModel.CustomerName;
            //sqlCommand.Parameters["@salary"].Value = CustomerModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override DataTable get(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }


        public override void update(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }
    }
}
