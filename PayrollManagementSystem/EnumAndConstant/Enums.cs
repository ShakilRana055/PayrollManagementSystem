using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EnumAndConstant
{
    public enum ApplicableFor
    {
        Male = 1,
        Female = 2,
        Both = 3,
    }

    public enum Gender
    {
        Male = 1,
        Female = 1,
    }

    public enum AttendanceStatus{
        Present = 1,
        Late = 2,
        Absent = 3,
    }
    public enum LeaveApplicationStatus
    {
        Loading = 1,
        Accepted = 2,
        Rejected = 3,
    }
    public enum LoanApplicationStatus
    {
        Loading = 1, 
        Accepted = 2,
        Rejected = 3,
    }
    public enum LoanPeriod
    {
        Weekly = 1,
        HalfMonthly = 2,
        Monthly = 3,
        ThreeMonthly = 4,
        HalfYearly = 5,
        Yearly = 6,
    }
    public enum PayableStatus
    {
        Paid = 1,
        Unpaid = 2,
    }
}
