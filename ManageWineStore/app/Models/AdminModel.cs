using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class AdminModel
    {
        public AdminModel(int id, string name, DateTime birth, int gender,
            string phone, string mail, string address, int? accountId)
        {
            Id = id;
            Name = name;
            Birth = birth;
            Gender = gender;
            Phone = phone;
            Mail = mail;
            Address = address;
            AccountId = accountId;
        }

        public AdminModel(DataRow row)
        {
            Id = (int)row["id"];
            Name = row["name"].ToString();
            Birth = DateTime.Parse(row["birth"].ToString());
            Gender = (int)row["gender"];
            Phone = row["phone"].ToString();
            Mail = row["mail"].ToString();
            Address = row["address"].ToString();
            AccountId = (int)row["account_id"];
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Birth { get; set; }
        public int Gender { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public Nullable<int> AccountId { get; set; }
    }
}
