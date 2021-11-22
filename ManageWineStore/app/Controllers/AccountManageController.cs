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
    class AccountManageController
    {
        private AccountController accountController = new AccountController();
        private RoleController roleController = new RoleController();

        public DataTable getAccounts()
        {
            return this.accountController.findAll();
        }

        public DataTable getRoles()
        {
            return this.roleController.findAll();
        }

        public DataTable search(string column, Object value)
        {
            return this.accountController.findByConditional(column, value);
        }

        public void createAccount(AccountModel accountModel)
        {
            this.accountController.insert(accountModel);
        }

        public void updateAccount(AccountModel accountModel)
        {
            this.accountController.update(accountModel);
        }

        public void removeAccount(string id)
        {
            this.accountController.delete(id);
        }
    }
}
