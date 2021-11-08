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
    class ImportReciptController : AModelController<ImportReciptModel>
    {
        public override void insert(ImportReciptModel importReciptModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO importRecipt VALUES (@importRecipt_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@importRecipt_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@importRecipt_name"].Value = importReciptModel.ImportReciptName;
            //sqlCommand.Parameters["@salary"].Value = importReciptModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override DataTable get(ImportReciptModel importReciptModel)
        {
            throw new NotImplementedException();
        }


        public override void update(ImportReciptModel importReciptModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(ImportReciptModel importReciptModel)
        {
            throw new NotImplementedException();
        }
    }
}
