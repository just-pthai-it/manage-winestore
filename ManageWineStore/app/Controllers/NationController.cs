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
    class NationController : AModelController<NationModel>
    {
        public override void insert(NationModel nationModel)
        {
            string commandText = "INSERT INTO Nation VALUES ( @name );";
            this.executeNonQuery(commandText, new object[] { nationModel.Name });
        }
        public override DataTable findAll()
        {
            string commandText = "SELECT * FROM nation ;";
            return this.executeQuery(commandText);
        }
        public override DataTable find(string column, object value)
        {
            throw new NotImplementedException();
        }

        public override void update(NationModel nationModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
