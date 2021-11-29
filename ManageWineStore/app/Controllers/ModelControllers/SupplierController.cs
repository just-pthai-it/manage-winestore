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
    class SupplierController : AModelController<SupplierModel>
    {
        public override void insert(SupplierModel supplierModel)
        {

        }

        public override DataTable find(string column, object value)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            string commandText = "SELECT * FROM supplier_info ;";
            return this.executeQuery(commandText);
        }

        public DataTable findByConditional(string column, Object value)
        {
            string commandText = "SELECT * FROM supplier_info WHERE " + column + " LIKE @" + column + " ;";
            return this.executeQuery(commandText, new object[] { "%" + value + "%" });
        }

        public override void update(SupplierModel supplierModel)
        {
            string commandText = "UPDATE supplier SET name = @name , phone = @phone , mail = @mail , " +
                                "address = @address , nation_id = @nation_id WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[]
            {
                supplierModel.Name,
                supplierModel.Phone,
                supplierModel.Mail,
                supplierModel.Address,
                supplierModel.NationID,
                supplierModel.Id,
            });
        }

        public override void delete(string id)
        {
            string commandText = "DELETE FROM supplier WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[] { id });
        }
    }
}
