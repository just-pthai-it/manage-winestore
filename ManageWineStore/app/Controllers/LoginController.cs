
using ManageWineStore.app.BussinessClasses;
using ManageWineStore.app.Controllers.ModelControllers;
using ManageWineStore.app.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageWineStore.app.Controllers
{
    class LoginController
    {
        private AccountController accountController;
        private AdminController adminController = null;
        private EmployeeController employeeController = null;


        public LoginController()
        {
            this.accountController = new AccountController();
            this.adminController = new AdminController();
            this.employeeController = new EmployeeController();
        }

        public Object login(string username, string password)
        {
            string hashPassword = MD5Helper.GetHash(password);
            DataTable dataTable = accountController.find(username, hashPassword);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["user_type_id"].ToString() == "1")
                {
                    return new EmployeeModel(employeeController.find(dataRow["id"].ToString()).Rows[0]);
                }

                return new AdminModel(adminController.find(dataRow["id"].ToString()).Rows[0]);

            }

            return null;
        }
    }
}
