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
    class JobController
    {
        private DatabaseConnector databaseConnector;

        public JobController()
        {
            this.databaseConnector = new DatabaseConnector();
        }

        public void insert()
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO job VALUES (@job_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@job_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            sqlCommand.Parameters["@job_name"].Value = "fsdfd";
            sqlCommand.Parameters["@salary"].Value = 100;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }
    }
}
