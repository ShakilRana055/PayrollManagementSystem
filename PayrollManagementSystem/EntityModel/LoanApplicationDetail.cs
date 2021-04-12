using PayrollManagementSystem.EnumAndConstant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class LoanApplicationDetail:BaseClass
    {
        public int Id { get; set; }
        public string InstallmentDate { get; set; }
        public int? LoanApplicationId { get; set; }
        public LoanApplication LoanApplication { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal InstallmentAmount { get; set; }
        public PayableStatus Status { get; set; }
    }
}
