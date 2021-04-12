using PayrollManagementSystem.EnumAndConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class LeaveType:BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfHoliday { get; set; }
        public ApplicableFor ApplicableFor { get; set; }
    }
    
}
