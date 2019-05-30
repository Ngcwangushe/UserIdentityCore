using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserIdentityCore.Models
{
    public class CustomUser
    {
        public CustomUser() : base()
        {

        }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
