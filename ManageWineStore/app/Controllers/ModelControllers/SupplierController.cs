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
    class SupplierController : AModelController<SupplierModel>
    {
        public override void insert(SupplierModel supplierModel)
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

        public override void update(SupplierModel supplierModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
