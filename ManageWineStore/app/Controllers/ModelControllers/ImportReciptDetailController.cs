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
    class ImportReciptDetailController : AModelController<ImportReciptDetailModel>
    {
        public override void insert(ImportReciptDetailModel importReciptDetailModel)
        {
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO importReciptDetail VALUES (@importReciptDetail_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@importReciptDetail_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@importReciptDetail_name"].Value = importReciptDetailModel.ImportReciptDetailName;
            //sqlCommand.Parameters["@salary"].Value = importReciptDetailModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override void get(ImportReciptDetailModel importReciptDetailModel)
        {
            throw new NotImplementedException();
        }


        public override void update(ImportReciptDetailModel importReciptDetailModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(ImportReciptDetailModel importReciptDetailModel)
        {
            throw new NotImplementedException();
        }
    }
}
