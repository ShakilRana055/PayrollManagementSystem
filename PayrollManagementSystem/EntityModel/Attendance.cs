using PayrollManagementSystem.EnumAndConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class Attendance:BaseClass
    {
        public int Id { get; set; }
        public string CurrentDate { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public AttendanceStatus Status { get; set; }
        public IEnumerable<AttendanceDetail> AttendanceDetails { get; set; }
    }
}
