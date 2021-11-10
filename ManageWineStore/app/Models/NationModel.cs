using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class NationModel
    {
        public NationModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public NationModel(DataRow row)
        {
            Id = (int)row["id"];
            Name = row["name"].ToString();
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
