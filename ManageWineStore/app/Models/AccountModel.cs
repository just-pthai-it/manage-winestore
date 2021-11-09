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
        public AccountModel(int id, string username, string password, int userId)
        {
            Id = id;
            Username = username;
            Password = password;
            UserTypeId = userId;
        }

        public AccountModel(DataRow row)
        {
            Id = (int)row["id"];
            Username = row["user_name"].ToString();
            Password = row["password"].ToString();
            UserTypeId = (int)row["user_type_id"];
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }

    }
}
