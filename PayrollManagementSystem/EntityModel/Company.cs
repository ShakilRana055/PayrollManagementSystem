using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class Company:BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string LogoUrl { get; set; }
        public string Slogan { get; set; }
        public string Currency { get; set; }
        public string OfficeStartTime { get; set; }
        public string OfficeEndTime { get; set; }
        public string GraceTime { get; set; }
        public string Password { get; set; }
    }
}
