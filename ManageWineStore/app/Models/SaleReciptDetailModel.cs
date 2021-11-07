﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class SaleReciptDetailModel
    {
        public SaleReciptDetailModel(int id, int saleReciptId, int merchandiseId, 
                                    int quantity, double cost)
        {
            Id = id;
            SaleReciptId = saleReciptId;
            MerchandiseId = merchandiseId;
            Quantity = quantity;
            Cost = cost;
        }

        public int Id { get; set; }
        public int SaleReciptId { get; set; }
        public int MerchandiseId { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
    }
}
