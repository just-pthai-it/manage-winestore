using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class MerchandiseModel
    {
        public MerchandiseModel(int id, int wineId, 
                            DateTime expiry, int originalQuantity, int currentQuantity)
        {
            Id = id;
            WineId = wineId;
            Expiry = expiry;
            OriginalQuantity = originalQuantity;
            CurrentQuantity = currentQuantity;
        }

        public int Id { get; set; }
        public int WineId { get; set; }
        public System.DateTime Expiry { get; set; }
        public int OriginalQuantity { get; set; }
        public int CurrentQuantity { get; set; }
    }
}
