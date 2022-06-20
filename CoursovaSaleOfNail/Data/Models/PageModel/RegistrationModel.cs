using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursovaSaleOfNail.Data.Models.PageModel
{
    public class RegistrationModel
    {
        public string name;
        public RegistrationModel(string error) {
            this.name = error;
        }
    }
}
