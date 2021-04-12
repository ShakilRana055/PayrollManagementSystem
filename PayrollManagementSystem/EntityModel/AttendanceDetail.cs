using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class AttendanceDetail:BaseClass
    {
        public int Id { get; set; }
        public int? AttendanceId { get; set; }
        public Attendance Attendance { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string TotalHour { get; set; }
    }
}
