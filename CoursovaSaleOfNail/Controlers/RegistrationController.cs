using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoursovaSaleOfNail.Data.Interfaces;
using CoursovaSaleOfNail.Data.Models.PageModel;

namespace CoursovaSaleOfNail.Controlers
{
    public class RegistrationController : Controller
    {
        
        public void setCookieName(string user_name)
        {
            Response.Cookies.Append("name", user_name);
        }
        public RegistrationController(iDBConn dBConn, iDataCheck dataCheck, iRWClient rWClient)
        {
            this.dBConn = dBConn;
            this.dataCheck = dataCheck;
           this.rWClient = rWClient;
        }
        public ViewResult Registration(string error) {
            return View("/Views/Clients/registration.cshtml", new RegistrationModel(error));
        }
        private readonly iDBConn dBConn;
        private readonly iDataCheck dataCheck;
        private readonly iRWClient rWClient;
      

        public RedirectToActionResult writeInBd(string user_name, string user_password, string user_telephone)
        {
            string value = dataCheck.cheakClient(user_name, user_password, user_telephone, rWClient, dBConn);
            if (value == "*" && rWClient.setClient(user_name, user_password, user_telephone, dBConn))
            {
                setCookieName(user_name);
                return RedirectToAction("goToClient", "Client");
            }
            else if (value == "*")
            {
                
                value = value + ("Невідома помилка;");
            }

           return RedirectToAction("Registration", "Registration",new { error = value});
        }
    }
}
