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
    class CustomerController : AModelController<CustomerModel>
    {
        public override void insert(CustomerModel customerModel)
        {
            string commandText = "INSERT INTO customer VALUES ( @name , @birth , " +
                    "@gender , @phone , @mail , @address , @image );";
            this.executeNonQuery(commandText, new object[]
            {
                customerModel.Name,
                customerModel.Birth,
                customerModel.Gender,
                customerModel.Phone,
                customerModel.Mail,
                customerModel.Address,
                customerModel.Image,
            });
        }

        public override DataTable find(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable findByConditional(string column, Object value)
        {
            string commandText = "SELECT * FROM customer WHERE " + column + " LIKE @" + column + " ;";
            return this.executeQuery(commandText, new object[] { "%" + value + "%" });
        }

        public override DataTable findAll()
        {
            string commandText = "SELECT * FROM customer ;";
            return this.executeQuery(commandText);
        }

        public override void update(CustomerModel customerModel)
        {
            string commandText = "UPDATE customer SET name = @name , birth = @birth , " +
                                "gender = @gender , phone = @phone , mail = @mail , " +
                                "address = @address , image = @image WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[]
            {
                customerModel.Name,
                customerModel.Birth,
                customerModel.Gender,
                customerModel.Phone,
                customerModel.Mail,
                customerModel.Address,
                customerModel.Image,
                customerModel.Id,
            });
        }

        public override void delete(string id)
        {
            string commandText = "DELETE FROM customer WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[] { id });
        }
    }
}
