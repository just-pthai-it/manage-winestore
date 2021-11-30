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
        public override void insert(WineModel wineModel)
        {
            string commandText = "INSERT INTO wine VALUES ( @wine_name , @alcohol_level , @image );";
            this.executeNonQuery(commandText, new object[] 
            {
                wineModel.WineName, 
                wineModel.AlcoholLevel,
                wineModel.Image,
            });
        }

        public override DataTable find(string column, object value)
        {
            throw new NotImplementedException();
        }

        public override DataTable findAll()
        {
            string commandText = "SELECT * FROM wine ;";
            return this.executeQuery(commandText);
        }

        public DataTable findIdAndName()
        {
            string commandText = "SELECT id, wine_name name FROM wine ;";
            return this.executeQuery(commandText);
        }

        public DataTable findByConditional(string column, Object value)
        {
            string commandText = "SELECT * FROM wine WHERE " + column + " LIKE @" + column + " ;";
            return this.executeQuery(commandText, new object[] { "%" + value + "%" });
        }

        public override void update(WineModel wineModel)
        {
            string commandText = "UPDATE wine SET wine_name = @wine_name , " +
                                "alcohol_level = @alcohol_level , image = @image WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[]
            {
                wineModel.WineName,
                wineModel.AlcoholLevel,
                wineModel.Image,
                wineModel.Id,
            });
        }

        public override void delete(string id)
        {
            string commandText = "DELETE FROM wine WHERE id = @id ;";
            this.executeNonQuery(commandText, new object[] { id });
        }
    }
}
