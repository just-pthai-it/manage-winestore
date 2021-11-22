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
    class StorageController
    {
        private MerchandiseController merchandiseController = new MerchandiseController();
        private WineController wineController = new WineController();

        public DataTable getMerchandises()
        {
            return this.merchandiseController.findAll();
        }

        public DataTable getWines()
        {
            return this.wineController.findIdAndName();
        }

        public DataTable search(string column, string value)
        {
            return this.merchandiseController.findByConditional(column, value);
        }

        public void updateMerchandise(MerchandiseModel MerchandiseModel)
        {
            this.merchandiseController.update(MerchandiseModel);
        }

        public void removeMerchandise(string id)
        {
            this.merchandiseController.delete(id);
        }
    }
}
