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
    class WineController : AModelController<WineModel>
    {
        public DataTable findAll()
        {
            string commandText = "SELECT * FROM wine_merchandise " +
                " ORDER BY wine_name, year_of_manufacture, merchandise_id;";
            return this.executeQuery(commandText);
        }
        public override void insert(WineModel wineModel)
        {
            string commandText = "INSERT INTO wine VALUES ( @wine_name , @alcohol_level , @price );";
            this.executeNonQuery(commandText, new object[] {
                wineModel.WineName, wineModel.AlcoholLevel, wineModel.Price
            });
        }

        public override DataTable get(WineModel wineModel)
        {
            throw new NotImplementedException();
        }

        public override void update(WineModel wineModel)
        {
            throw new NotImplementedException();
        }

        public override void delete(WineModel wineModel)
        {
            throw new NotImplementedException();
        }
    }
}
