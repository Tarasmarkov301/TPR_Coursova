using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Odbc;
using CoursovaSaleOfNail.Data.Models.BDModel;
namespace CoursovaSaleOfNail.Data.Interfaces
{
    public interface iReadNail
    {
       // IEnumerable<Nail> getNailsInformation(OdbcDataReader reader);
       // Nail getNailInformation(OdbcDataReader reader);
        IEnumerable<Nail> ALLNail(iDBConn dBConn);
        IEnumerable<Nail> ALLNailBuyRestrictions(int price, string name, iDBConn dBConn);
        Nail getOneNail(int id, iDBConn dBConn);
    }
}
