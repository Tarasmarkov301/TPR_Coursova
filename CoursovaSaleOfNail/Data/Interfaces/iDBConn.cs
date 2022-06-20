using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CoursovaSaleOfNail.Data.Interfaces
{
    public interface iDBConn
    {
       void open();
       OdbcDataReader executeRead(string commandText);
       bool executeNon(string commandText);
       void close();
    }
}
