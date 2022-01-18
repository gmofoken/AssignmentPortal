using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPortal.Models
{
    public class UserObject
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Identifier { get; set; }
    }

    public class Users
    {
        public int UserId { get; set; }
        public string Identifier { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
