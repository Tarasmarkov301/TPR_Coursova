using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursovaSaleOfNail.Data.Interfaces;
using System.Data.Odbc;

namespace CoursovaSaleOfNail.Data.Mock
{
    public class RWClient : iRWClient
    {
        private int getIntFromReader(OdbcDataReader reader)
        {
            reader.Read();
            return reader.GetInt32(0);
        }
        public bool getClient(string name, iDBConn dBConn)
        {
            string CommandText = "SELECT COUNT(*) as c FROM Client WHERE name = '" + name + "'";
            dBConn.open();
            int count = getIntFromReader(dBConn.executeRead(CommandText));
            dBConn.close();
            return count > 0;
        }
        public bool getPass(string name, string pass, iDBConn dBConn)
        {
            string CommandText = "SELECT COUNT(*) as c FROM Client WHERE name = '" + name + "' and password = '" + pass + "'";
            dBConn.open();
            int count = getIntFromReader(dBConn.executeRead(CommandText));
            dBConn.close();
            return count == 1;
        }
        public bool setClient(string name, string pass, string telephone, iDBConn dBConn)
        {
            string CommandText = "INSERT INTO Client(name, telephone, password) VALUES('" + name + "', '" + telephone + "', '" + pass + "');";
            dBConn.open();
            bool ok = dBConn.executeNon(CommandText);
            dBConn.close();
            return ok;
        }
    }
}
