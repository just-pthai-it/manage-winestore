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
    class EmployeeManageController
    {
        private EmployeeController employeeController = new EmployeeController();
        private JobController jobController = new JobController();

        public DataTable getEmployees()
        {
            return this.employeeController.findAll();
        }

        public DataTable getJobs()
        {
            return this.jobController.findAll();
        }

        public DataTable search(string column, string value)
        {
            return this.employeeController.findByConditional(column, value);
        }

        public void createEmployee(EmployeeModel employeeModel)
        {
            this.employeeController.insert(employeeModel);
        }

        public void updateEmployee(EmployeeModel employeeModel)
        {
            this.employeeController.update(employeeModel);
        }

        public void removeEmployee(string id)
        {
            this.employeeController.delete(id);
        }
    }
}
