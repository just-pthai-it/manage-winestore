
using ManageWineStore.app.BussinessClasses;
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
    class LoginController
    {
        private AccountController accountController;
        private AdminController adminController;
        private EmployeeController employeeController;


        public LoginController()
        {
            this.accountController = new AccountController();
            this.adminController = new AdminController();
            this.employeeController = new EmployeeController();
        }

        public DataTable login(string username, string password)
        {
            string hashPassword = MD5Helper.GetHash(password);
            DataTable dataTable = accountController.find(username, hashPassword);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["user_id"].ToString() == "2")
                {
                    return employeeController.find(dataRow["id"].ToString());
                }

                return adminController.find(dataRow["id"].ToString());

            }

            return null;
        }
    }
}
