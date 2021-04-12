using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = System.DateTime.Now.ToString();
        }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
