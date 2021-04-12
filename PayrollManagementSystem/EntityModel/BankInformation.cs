using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class BankInformation:BaseClass
    {
        public int Id { get; set; }
        public int? BankId { get; set; }
        public Bank Bank { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string Branch { get; set; }
    }
}
