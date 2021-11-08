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
    class JobController : AModelController<JobModel>
    {
        public override void insert(JobModel jobModel)
        {
            string commandText = "INSERT INTO job VALUES ( @job_name , @salary );";
            this.executeNonQuery(commandText, new object[]
            {
                jobModel.JobName,
                jobModel.Salary
            });
        }

        public override DataTable get (JobModel jobModel)
        {
            throw new NotImplementedException();
        }


        public override void update(JobModel jobModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(JobModel jobModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "DELETE FROM job WHERE id = @id;";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int);
            sqlCommand.Parameters["@id"].Value = jobModel.Id;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }
    }
}
