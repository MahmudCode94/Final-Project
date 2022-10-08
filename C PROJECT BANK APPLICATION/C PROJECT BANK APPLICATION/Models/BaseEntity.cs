using System;
using System.Collections.Generic;
using System.Text;

namespace C_PROJECT_BANK_APPLICATION.Models
{
    public class BaseEntity
    {
        public string Name { get; set; }
        public bool SoftDelete { get; set; }

    }
}