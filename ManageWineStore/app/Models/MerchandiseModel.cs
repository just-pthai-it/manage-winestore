using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class MerchandiseModel
    {
        public MerchandiseModel(int? id, int wineId, string yearOfManufacture, 
                                int currentQuantity, double pricePerProduct)
        {
            Id = id;
            WineId = wineId;
            YearOfManufacture = yearOfManufacture;
            CurrentQuantity = currentQuantity;
            PricePerProduct = pricePerProduct;
        }

        public Nullable<int> Id { get; set; }
        public int WineId { get; set; }
        public string YearOfManufacture { get; set; }
        public int CurrentQuantity { get; set; }
        public double PricePerProduct { get; set; }
    }
}
