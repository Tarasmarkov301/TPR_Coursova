using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursovaSaleOfNail.Data.Models.BDModel;

namespace CoursovaSaleOfNail.Data.Interfaces
{
    public interface iRWSale
    {
        IEnumerable<Nail> saleByType(string nameOfClient, int num, iDBConn dBConn);
        bool setSale(int numberOfNail, string clientName, iDBConn dBConn);
    }
}
