using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class ImportReceiptDetailModel
    {
        public ImportReceiptDetailModel(int? id, int? importReciptId,
                        int? merchandiseId, int quantity, double cost)
        {
            Id = id;
            ImportReceiptId = importReciptId;
            MerchandiseId = merchandiseId;
            Quantity = quantity;
            Cost = cost;
        }

        public ImportReceiptDetailModel(int? id, int? importReciptId,
                int? merchandiseId, int quantity, double cost, string wineName, string mfg)
        {
            Id = id;
            ImportReceiptId = importReciptId;
            MerchandiseId = merchandiseId;
            Quantity = quantity;
            Cost = cost;
            WineName = wineName;
            MFG = mfg;
        }

        public Nullable<int> Id { get; set; }
        public Nullable<int> ImportReceiptId { get; set; }
        public Nullable<int> MerchandiseId { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public string WineName { get; set; }
        public string MFG { get; set; }
        public override string ToString()
        {
            return "Tên rượu: " + this.WineName +
                " - Năm SX: " + this.MFG +
                " - Số lượng: " + this.Quantity +
                " - Thành tiền: " + this.Cost;
        }
    }
}
