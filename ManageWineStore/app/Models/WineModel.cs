using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class WineModel
    {
        public WineModel(int id, string wineName, int alcoholLevel, double price)
        {
            Id = id;
            WineName = wineName;
            AlcoholLevel = alcoholLevel;
            Price = price;
        }

        public int Id { get; set; }
        public string WineName { get; set; }
        public int AlcoholLevel { get; set; }
        public double Price { get; set; }
    }
}
