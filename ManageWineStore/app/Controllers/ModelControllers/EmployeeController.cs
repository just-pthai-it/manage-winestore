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
using System.Windows.Forms;

namespace ManageWineStore.app.Controllers.ModelControllers
{
    class EmployeeController : AModelController<EmployeeModel>
    {
        public override void insert(EmployeeModel employeeModel)
        {
            string commandText = "INSERT INTO employee VALUES ( @name , @birth , " +
                                "@gender , @phone , @mail , @address , @job_id , @account_id , @image );";
            this.executeNonQuery(commandText, new object[]
            {
                employeeModel.Name,
                employeeModel.Birth,
                employeeModel.Gender,
                employeeModel.Phone,
                employeeModel.Mail,
                employeeModel.Address,
                employeeModel.JobId,
                employeeModel.AccountId,
                employeeModel.Image,
            });
        }
        public DataTable findByConditional(string column, Object value)
        {
            string commandText = "SELECT * FROM employee_info WHERE " + column + " LIKE @" + column + " ;";
            return this.executeQuery(commandText, new object[] { "%" + value + "%" });
        }
        public override DataTable find(string column, object value)
        {
            string commandText = "SELECT * FROM employee WHERE " + column + " = @"+ column +" ;";
            return this.executeQuery(commandText, new object[] { value });
        }

        public override DataTable findAll()
        {
            string commandText = "SELECT * FROM employee_info ;";
            return this.executeQuery(commandText);
        }

        public override void update(EmployeeModel employeeModel)
        {
            string commandText = "UPDATE employee SET name = @name , birth = @birth , " +
                                "gender = @gender , phone = @phone , mail = @mail , " +
                                "address = @address , job_id = @job_id , account_id = @account_id " +
                                ", image = @image WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[]
            {
                employeeModel.Name,
                employeeModel.Birth,
                employeeModel.Gender,
                employeeModel.Phone,
                employeeModel.Mail,
                employeeModel.Address,
                employeeModel.JobId,
                employeeModel.AccountId,
                employeeModel.Image,
                employeeModel.Id,
            });
        }

        public override void delete(string id)
        {
            string commandText = "DELETE FROM employee WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[] { id });
        }
    }
}
