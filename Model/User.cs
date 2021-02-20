using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoolExplorer.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Status { get; set; }
       
    }

    public enum RoleEnum
    {
        Operator,
        Parent,
        Admin
    }
}
