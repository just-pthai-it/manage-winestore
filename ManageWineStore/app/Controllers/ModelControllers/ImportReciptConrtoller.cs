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
    class ImportReceiptController : AModelController<ImportReceiptModel>
    {
        public int insertGetId(ImportReceiptModel importReciptModel)
        {
            string commandText = "INSERT INTO import_receipt output INSERTED.id VALUES ( @create_at , @employee_id , " +
                                "@supplier_id , @total_money );";
            return (int)this.ExecuteScalar(commandText, new object[] {
                importReciptModel.CreateAt,
                importReciptModel.EmployeeId,
                importReciptModel.SupplierId,
                importReciptModel.TotalMoney,
            });
        }

        public override void insert(ImportReceiptModel importReciptModel)
        {

        }

        public override DataTable find(string id)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            throw new NotImplementedException();
        }

        public override void update(ImportReceiptModel importReciptModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
