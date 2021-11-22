using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class AccountModel
    {
        public AccountModel(int? id, string username, string password, int roleId)
        {
            Id = id;
            Username = username;
            Password = password;
            RoleId = roleId;
        }

        public AccountModel(DataRow row)
        {
            Id = (int)row["id"];
            Username = row["user_name"].ToString();
            Password = row["password"].ToString();
            RoleId = (int)row["role_id"];
        }

        public Nullable<int> Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

    }
}
