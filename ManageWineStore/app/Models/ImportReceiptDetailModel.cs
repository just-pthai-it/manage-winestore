using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class ImportReceiptDetailModel
    {
        public ImportReceiptDetailModel(int id, int importReciptId,
                        int merchandiseId, int quantity, double cost)
        {
            Id = id;
            ImportReceiptId = importReciptId;
            MerchandiseId = merchandiseId;
            Quantity = quantity;
            Cost = cost;
        }

        public int Id { get; set; }
        public int ImportReceiptId { get; set; }
        public int MerchandiseId { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
    }
}
