using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursovaSaleOfNail.Data.Models.BDModel;

namespace CoursovaSaleOfNail.Data.Interfaces
{
    public interface iDataCheck
    {
        string cheakClient(string user_name, string user_password, string user_telephone, iRWClient client, iDBConn dBConn);
    }
}
