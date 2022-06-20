using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursovaSaleOfNail.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CoursovaSaleOfNail.Data.Models.PageModel;
using CoursovaSaleOfNail.Data.Models.BDModel;

namespace CoursovaSaleOfNail.Controlers
{
    public class ClientController : Controller
    {
        public ClientController(iReadNail allNail, iDBConn bDConn, iRWSale rWSale)
        {
            this.allNail = allNail;
            this.bDConn = bDConn;
            this.rWSale = rWSale;
        }
        private readonly iReadNail allNail;
        private readonly iDBConn bDConn;
        private readonly iRWSale rWSale;
        public string getCookieName()
        {
            string name;
            if (Request.Cookies.TryGetValue("name", out name))
            {
                return name;
            }
            else
            {
                return "";
            }
        }
        public ViewResult goToClient()
        {
            string name = getCookieName();
            IEnumerable<Nail> inProcess = rWSale.saleByType(name, 1, bDConn);
            IEnumerable<Nail> done      = rWSale.saleByType(name, 2, bDConn);
            IEnumerable<Nail> notDone   = rWSale.saleByType(name, 3, bDConn);
            return Client(inProcess, done, notDone, name);
        }
        public ViewResult Client(IEnumerable<Nail> inProcess, IEnumerable<Nail> done, IEnumerable<Nail> notDone, string name)
        {
            return View("/Views/Clients/List.cshtml", new ClientBuy(inProcess,done, notDone, name));
        }

    }
}
