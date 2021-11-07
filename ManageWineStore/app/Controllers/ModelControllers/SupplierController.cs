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
            databaseConnector.OpenConnect();
            string commandText = "INSERT INTO supplier VALUES (@supplier_name, @salary);";
            SqlCommand sqlCommand = new SqlCommand(commandText, databaseConnector.SqlConnect);
            sqlCommand.Parameters.Add("@supplier_name", SqlDbType.NVarChar);
            sqlCommand.Parameters.Add("@salary", SqlDbType.Float);
            //sqlCommand.Parameters["@supplier_name"].Value = supplierModel.SupplierName;
            //sqlCommand.Parameters["@salary"].Value = supplierModel.Salary;
            sqlCommand.ExecuteNonQuery();
            databaseConnector.CloseConnect();
        }

        public override void get(SupplierModel supplierModel)
        {
            throw new NotImplementedException();
        }


        public override void update(SupplierModel supplierModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(SupplierModel supplierModel)
        {
            throw new NotImplementedException();
        }
    }
}
