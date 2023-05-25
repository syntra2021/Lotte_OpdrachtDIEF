using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDIEF.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string BirthDate { get; set; }
        public string StartDate { get; set; }
    }
}
