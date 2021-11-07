using ManageWineStore.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Controllers.ModelControllers.Abastract
{
    abstract class AModelController<T>
    {
        protected DatabaseConnector databaseConnector;

        protected AModelController()
        {
            this.databaseConnector = new DatabaseConnector();
        }

        public abstract void insert(T obj);

        public abstract void get(T obj);

        public abstract void update(T obj);

        public abstract void delete(T obj);

    }
}
