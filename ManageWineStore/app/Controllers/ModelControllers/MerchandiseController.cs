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
    class MerchandiseController : AModelController<MerchandiseModel>
    {
        public override void insert(MerchandiseModel merchandiseModel)
        {
            string commandText = "INSERT INTO merchandise VALUES ( @winde_id , @year_of_manufacture , " +
                                "@current_quantity , @price_per_product );";
            this.executeNonQuery(commandText, new object[]
            {
                merchandiseModel.WineId,
                merchandiseModel.YearOfManufacture,
                merchandiseModel.CurrentQuantity,
                merchandiseModel.PricePerProduct
            });
        }

        public override DataTable find(string id)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            string commandText = "SELECT * FROM merchandise_wine " +
                                " ORDER BY merchandise_id, wine_name, year_of_manufacture;";
            return this.executeQuery(commandText);
        }

        public DataTable findAll2()
        {
            string commandText = "SELECT * FROM wine_merchandise " +
                                " ORDER BY wine_name, year_of_manufacture, merchandise_id;";
            return this.executeQuery(commandText);
        }

        public DataTable findByConditional(string column, string value)
        {
            string commandText = "SELECT * FROM merchandise_wine WHERE " + column + " LIKE @" + column + " ;";
            return this.executeQuery(commandText, new object[] { "%" + value + "%" });
        }

        public override void update(MerchandiseModel merchandiseModel)
        {
            string commandText = "UPDATE merchandise SET wine_id = @winde_id , " +
                                "year_of_manufacture = @year_of_manufacture , " +
                                  "current_quantity = @current_quantity , " +
                                  "price_per_product = @price_per_product WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[]
            {
                merchandiseModel.WineId,
                merchandiseModel.YearOfManufacture,
                merchandiseModel.CurrentQuantity,
                merchandiseModel.PricePerProduct,
                merchandiseModel.Id
            });
        }

        public override void delete(string id)
        {
            string commandText = "DELETE FROM merchandise WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[] { id });
        }
    }
}
