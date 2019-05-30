using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserIdentityCore.Models
{
    public class CustomRole : IdentityRole
    {
        public CustomRole() : base() { }
        public CustomRole(string roleName) : base(roleName) { }

        public CustomRole(string roleName, string decription, DateTime creationDate) : base(roleName)
        {
            this.Description = decription;
            this.CreationDate = creationDate;
        }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
