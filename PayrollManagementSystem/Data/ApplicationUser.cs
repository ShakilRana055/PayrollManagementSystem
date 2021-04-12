using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string PhotoUrl { get; set; }
    }
}
