using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoursovaSaleOfNail.Data.Interfaces;
using CoursovaSaleOfNail.Data.Models.BDModel;
using CoursovaSaleOfNail.Data.Models.PageModel;
using Microsoft.AspNetCore.Http;

namespace CoursovaSaleOfNail.Controles
{
    public class NailController : Controller
    {
        public NailController(iReadNail allNail, iDBConn bDConn, iRWClient rWClient)
        {
            this.allNail = allNail;
            this.bDConn = bDConn;
            this.rWClient = rWClient;
        }
        private readonly iReadNail allNail;
        private readonly iDBConn bDConn;
        private readonly iRWClient rWClient;

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

        public void setCookieName(string user_name)
        {
            Response.Cookies.Append("name", user_name);
        }
        public ViewResult List()
        {
            var nail = allNail.ALLNail(bDConn);
            NailAndClient nac = new NailAndClient(nail,getCookieName());
            return View("/Views/Nail/List.cshtml", nac);
        }

        public ViewResult findNail(int maxPrice, string name)
        {
            var nail = allNail.ALLNailBuyRestrictions(maxPrice, name, bDConn);
            NailAndClient nac = new NailAndClient(nail, getCookieName());
            return View("/Views/Nail/List.cshtml", nac);
        }
        public RedirectToActionResult oneNail(int id)
        {
            return RedirectToAction( "oneNail", "BuyNail", new { id = id });
        }
        [HttpPost]
        public ViewResult enter(string user_name, string user_password)
        {
            if (rWClient.getPass(user_name, user_password, bDConn))
            {
                setCookieName(user_name);
            }
            return List();
        }

    }
}
