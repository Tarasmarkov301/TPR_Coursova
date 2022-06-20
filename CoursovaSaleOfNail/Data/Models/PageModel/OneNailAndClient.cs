using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursovaSaleOfNail.Data.Models.BDModel;

namespace CoursovaSaleOfNail.Data.Models.PageModel
{
    public class OneNailAndClient
    {
        public Nail nail;
        public string name;
        public OneNailAndClient(Nail nail, string name) {
            this.nail = nail;
            this.name = name;
        }
    }
}
