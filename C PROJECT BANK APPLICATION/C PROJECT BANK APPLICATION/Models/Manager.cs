using System;
using System.Collections.Generic;
using System.Text;

namespace C_PROJECT_BANK_APPLICATION.Models
{
    public class Manager : BaseEntity
    {
        public string Surname { get; set; }
        public string Username { get; set; }
        public int Userpassword { get; set; }
        public Manager()
        {
            Username = "Salman";
            Userpassword = 725626;
        }
    }
}
