using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class SupplierModel
    {
        public SupplierModel(int? id, string name, string phone, string mail, 
                            string address, int nationId)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Mail = mail;
            Address = address;
            NationID = nationId;
        }

        public Nullable<int> Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public int NationID { get; set; }
    }
}
