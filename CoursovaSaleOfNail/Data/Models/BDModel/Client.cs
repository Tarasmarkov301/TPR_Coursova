using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursovaSaleOfNail.Data.Models.BDModel
{
    public class Client
    {
        public string name;
        public string phone;
        public string pass;
        public Client(string name, string phone, string pass)
        {
            this.name = name;
            this.pass = pass;
            this.phone = phone;
        }
    }
}
