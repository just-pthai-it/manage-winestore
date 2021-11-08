using System;
using System.Collections.Generic;
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
            UserId = userId;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }

    }
}
