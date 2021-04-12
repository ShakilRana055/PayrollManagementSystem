using PayrollManagementSystem.EnumAndConstant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class LoanApplication:BaseClass
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int? LoanTypeId { get; set; }
        public LoanType LoanType { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal LoanAmount { get; set; }
        public int NumberOfInstallment { get; set; }
        public LoanPeriod Period { get; set; }
        public LoanApplicationStatus Status { get; set; }
        public IEnumerable<LoanApplicationDetail> LoanApplicationDetails { get; set; }
    }
}
