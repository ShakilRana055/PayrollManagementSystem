using PayrollManagementSystem.EnumAndConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class LeaveApplication:BaseClass
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int? LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public string Description { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public LeaveApplicationStatus Status { get; set; }
    }
}
