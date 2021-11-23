using ManageWineStore.app.Controllers.ModelControllers;
using ManageWineStore.app.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Controllers
{
    class SupplierManageController
    {
        private SupplierController supplierController = new SupplierController();
        private NationController nationController = new NationController();

        public DataTable getSupplilers()
        {
            return this.supplierController.findAll();
        }

        public DataTable getNations()
        {
            return this.nationController.findAll();
        }

        public DataTable search(string column, string value)
        {
            return this.supplierController.findByConditional(column, value);
        }

        public void createSupplier(SupplierModel supplierModel)
        {
            this.supplierController.insert(supplierModel);
        }

        public void updateSupplier(SupplierModel employeeModel)
        {
            this.supplierController.update(employeeModel);
        }

        public void removeSupplier(string id)
        {
            this.supplierController.delete(id);
        }
    }
}
