using PayrollManagementSystem.EnumAndConstant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class Employee:BaseClass
    {
        [Key]
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PhotoUrl { get; set; }
        public Gender Gender { get; set; }
        public string NID { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public int? DesignationId { get; set; }
        public Designation Designation { get; set; }
        public SalaryStructure SalaryStructure { get; set; }
        public IEnumerable<BankInformation> BankInformations { get; set; }
        public IEnumerable<Attendance> Attendance { get; set; }
        public IEnumerable<LeaveApplication> LeaveApplications { get; set; }
        public IEnumerable<LoanApplication> LoanApplications { get; set; }
    }
}
