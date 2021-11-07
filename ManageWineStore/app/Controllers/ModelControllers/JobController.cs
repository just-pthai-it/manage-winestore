﻿using ManageWineStore.app.Controllers.ModelControllers.Abastract;
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
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO job VALUES (@job_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@job_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@job_name"].Value = jobModel.JobName;
            //sqlCommand.Parameters["@salary"].Value = jobModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override void get(JobModel jobModel)
        {
            throw new NotImplementedException();
        }


        public override void update(JobModel jobModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(JobModel jobModel)
        {
            throw new NotImplementedException();
        }
    }
}