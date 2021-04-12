using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class SalaryStructure:BaseClass
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal Basic { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal Gross { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal MobileBill { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal HouseRent { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal TransportationCost { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal OtherCost { get; set; }
    }
}
