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
    class CustomerManageController
    {
        private CustomerController customerController = new CustomerController();

        public DataTable getCustomers()
        {
            return this.customerController.findAll();
        }

        public DataTable search(string column, string value)
        {
            return this.customerController.findByConditional(column, value);
        }
        public void createCustomer(CustomerModel CustomerModel)
        {
            this.customerController.insert(CustomerModel);
        }

        public void updateCustomer(CustomerModel CustomerModel)
        {
            this.customerController.update(CustomerModel);
        }

        public void removeCustomer(string id)
        {
            this.customerController.delete(id);
        }
    }
}
