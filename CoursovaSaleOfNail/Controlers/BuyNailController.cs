using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoursovaSaleOfNail.Data.Interfaces;
using CoursovaSaleOfNail.Data.Models.PageModel;

namespace CoursovaSaleOfNail.Controlers
{
    public class BuyNailController : Controller
    {
        public BuyNailController(iReadNail allNail, iDBConn bDConn, iRWSale rWSale)
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
        public ViewResult oneNail(int id)
        {
            var nail = allNail.getOneNail(id, bDConn);
            OneNailAndClient nac = new OneNailAndClient(nail, getCookieName());
            return View("/Views/Nail/OneNail.cshtml", nac);
        }
        public ViewResult writeSaleInBD(int numberOfNail)
        {
            string name;
            if (Request.Cookies.TryGetValue("name", out name))
            {
                rWSale.setSale(numberOfNail, name,bDConn);
            }
            return oneNail(numberOfNail);
        }
    }
}
