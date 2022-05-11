
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geekroad.Storage.Entity
{
    public class UserProto
    {

        public Guid Id { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserProto(Guid id, string nickname, string password, string email)
        {
            Id = id;
            Nickname = nickname;
            Password = password;
            Email = email;
        }
    }
}
