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
    class RoleController : AModelController<RoleModel>
    {
        public override void insert(RoleModel roleModel)
        {

        }

        public override DataTable find(string id)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public override void update(RoleModel roleModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
