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
    class PersonalInforController
    {
        private AccountController accountController = new AccountController();
        private EmployeeController employeeController = new EmployeeController();
        private AdminController adminController = new AdminController();
        private JobController jobController = new JobController();

        public DataTable getJobs()
        {
            return jobController.findAll();
        }

        public AdminModel updateAdminInfo(AdminModel adminModel)
        {
            this.adminController.update(adminModel);
            return adminModel;
        }

        public EmployeeModel updateEmployeeInfo(EmployeeModel employeeModel)
        {
            this.employeeController.update(employeeModel);
            return employeeModel;
        }
    }
}
