using System;
using System.Collections.Generic;
using System.Text;

namespace pos.BO
{
    public class Roles
    {
        public Roles()
        {
            this.Users = new List<User>();
        }

        public string RoleName { get; set; }
        public int RoleID { get; set; }

        public List<User> Users { get; set; }
    }
}
