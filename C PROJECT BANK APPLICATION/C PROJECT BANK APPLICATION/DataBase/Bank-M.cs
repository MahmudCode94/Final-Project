using System;
using System.Collections.Generic;
using System.Text;

namespace C_PROJECT_BANK_APPLICATION.DataBase
{
    public class Bank_M<T>
    {
        public List<T> Datas = new List<T>();
        public Bank_M()
        {
            Datas = new List<T>();
        }
    }
}

