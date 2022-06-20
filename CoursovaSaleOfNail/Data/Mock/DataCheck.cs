using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursovaSaleOfNail.Data.Interfaces;
using CoursovaSaleOfNail.Data.Models.BDModel;

namespace CoursovaSaleOfNail.Data.Mock
{
    public class DataCheck : iDataCheck
    {
        public string cheakClient(string user_name, string user_password, string user_telephone, iRWClient client, iDBConn dBConn)
        {
            string value = "*";
            if (user_password.Length > 20)
            {
                value = "*пароль дуже довгий(максимум 20 символів);";
            }
            if (user_password.Length <= 4)
            {
                value = "*пароль дуже короткий(мінімум 5 символів);";
            }
            if (user_password.Length > 320)
            {
                value = value + "ім'я дуже довге(максимум 320 символів)";
            }
            if (client.getClient(user_name, dBConn))
            {
                value = value + "таке їм'я вже використовуеться;";
            }
            return value;
        }
    }
}
