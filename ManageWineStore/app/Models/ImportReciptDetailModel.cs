using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class ImportReciptDetailModel
    {
        public ImportReciptDetailModel(int id, int importReciptId,
                        int merchandiseId, int quantity, double cost)
        {
            Id = id;
            ImportReciptId = importReciptId;
            MerchandiseId = merchandiseId;
            Quantity = quantity;
            Cost = cost;
        }

        public int Id { get; set; }
        public int ImportReciptId { get; set; }
        public int MerchandiseId { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
    }
}
