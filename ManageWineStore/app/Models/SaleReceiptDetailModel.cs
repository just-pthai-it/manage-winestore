using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class SaleReceiptDetailModel
    {
        public SaleReceiptDetailModel(int id, int saleReciptId, int merchandiseId, 
                                    int quantity, double cost)
        {
            Id = id;
            SaleReceiptId = saleReciptId;
            MerchandiseId = merchandiseId;
            Quantity = quantity;
            Cost = cost;
        }

        public SaleReceiptDetailModel(int merchandiseId, int quantity, double cost, string name, string mfg)
        {
            Id = -1;
            SaleReceiptId = -1;
            MerchandiseId = merchandiseId;
            Quantity = quantity;
            Cost = cost;
            Name = name;
            MFG = mfg;

        }

        public int Id { get; set; }
        public int SaleReceiptId { get; set; }
        public int MerchandiseId { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public string Name { get; set; }
        public string MFG { get; set; }
        public override string ToString()
        {
            return "Tên rượu: " + this.Name + 
                " - Năm SX: " + this.MFG +
                " - Số lượng: " + this.Quantity +
                " - Thành tiền: " +this.Cost;
        }
    }
}
