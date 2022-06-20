using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursovaSaleOfNail.Data.Models.BDModel;

namespace CoursovaSaleOfNail.Data.Models.PageModel
{
    public class NailAndClient
    {
       public IEnumerable<Nail> nails;
        public string name;
        public NailAndClient(IEnumerable<Nail> nails, string name) {
            this.nails = nails;
            this.name = name;
        }
    }
}
