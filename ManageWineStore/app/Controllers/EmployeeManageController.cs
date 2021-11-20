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

        public DataTable loadData()
        {
            return this.employeeController.findAll();
        }

        public DataTable getJobs()
        {
            return jobController.findAll();
        }

        public DataTable search(string column, string value)
        {
            return employeeController.findByConditional(column, value);
        }

        public void createEmployee(EmployeeModel employeeModel)
        {
            employeeController.insert(employeeModel);
        }

        public void updateEmployee(EmployeeModel employeeModel)
        {
            employeeController.update(employeeModel);
        }

        public void removeEmployee(string id)
        {
            employeeController.delete(id);
        }
    }
}
