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
    class WineManageController
    {
        private WineController wineController = new WineController();

        public DataTable getWines()
        {
            return wineController.findAll();
        }

        public DataTable search(string column, string value)
        {
            return wineController.findByConditional(column, value);
        }

        public void createWine(WineModel wineModel)
        {
            wineController.insert(wineModel);
        }

        public void updateWine(WineModel wineModel)
        {
            wineController.update(wineModel);
        }

        public void removeWine(string id)
        {
            wineController.delete(id);
        }
    }
}
