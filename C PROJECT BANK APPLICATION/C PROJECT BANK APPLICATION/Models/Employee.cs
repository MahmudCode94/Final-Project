using System;
using System.Collections.Generic;
using System.Text;

namespace C_PROJECT_BANK_APPLICATION.Models
{
    public class Employee : BaseEntity
    {
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Profession { get; set; }
        public Branch branch { get; set; }
    }
}
