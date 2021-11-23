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
    class AdminController : AModelController<AdminModel>
    {
        public override void insert(AdminModel adminModel)
        {

        }

        public override DataTable find(string column, object value)
        {
            string commandText = "SELECT * FROM admin WHERE " + column + " = @" + column + " ;";
            return this.executeQuery(commandText, new object[] { value });
        }

        public override DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public override void update(AdminModel adminModel)
        {
            string commandText = "UPDATE admin SET name = @name , birth = @birth , " +
                                "gender = @gender , phone = @phone , mail = @mail , " +
                                "address = @address , account_id = @account_id " +
                                ", image = @image WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[]
            {
                adminModel.Name,
                adminModel.Birth,
                adminModel.Gender,
                adminModel.Phone,
                adminModel.Mail,
                adminModel.Address,
                adminModel.AccountId,
                adminModel.Image,
                adminModel.Id,
            });
        }

        public override void delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
