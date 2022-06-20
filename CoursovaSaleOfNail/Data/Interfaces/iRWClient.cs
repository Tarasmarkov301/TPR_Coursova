using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursovaSaleOfNail.Data.Interfaces
{
    public interface iRWClient
    {
        bool setClient(string name, string pass, string telephone, iDBConn dBConn);
        bool getClient(string name, iDBConn dBConn);
        bool getPass(string name, string pass, iDBConn dBConn);
    }
}
