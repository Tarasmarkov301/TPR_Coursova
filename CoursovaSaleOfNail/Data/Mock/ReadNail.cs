using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;
using CoursovaSaleOfNail.Data.Interfaces;
using CoursovaSaleOfNail.Data.Models.BDModel;

namespace CoursovaSaleOfNail.Data.Mock
{
    public class ReadNail : iReadNail
    {
        
        private Nail getNailInformation(OdbcDataReader reader)
        {
            Nail ret = new Nail("1", 0, 0, "1", "1");
            if(reader.Read())
            {
                string name = reader.GetString(0);
                int number = reader.GetInt32(1);
                int price1 = reader.GetInt32(2);
                string foto = reader.GetString(3);
                string description = reader.GetString(4);
                ret = new Nail(name, number, price1, foto, description);
            }
            return ret;
        }

        private IEnumerable<Nail> getNailsInformation(OdbcDataReader reader)
        {
            List<Nail> nails = new List<Nail>();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                int number = reader.GetInt32(1);
                int price1 = reader.GetInt32(2);
                string foto = reader.GetString(3);
                string description = reader.GetString(4);
                nails.Add(new Nail(name, number, price1, foto, description));
            };
            return nails;
        }

        public IEnumerable<Nail> ALLNail(iDBConn dBConn)
        {
            string CommandText = "SELECT * FROM Nail";
            dBConn.open();
            IEnumerable<Nail> nails = getNailsInformation(dBConn.executeRead(CommandText));
            dBConn.close();
            return nails;
        }

        public IEnumerable<Nail> ALLNailBuyRestrictions(int price, string name, iDBConn dBConn)
        {
            string CommandText = "SELECT * FROM Nail WHERE price < " + price + "AND name LIKE '%" + name + "%'";
            dBConn.open();
            IEnumerable<Nail> nails = getNailsInformation(dBConn.executeRead(CommandText));
            dBConn.close();
            return nails;
        }

        public Nail getOneNail(int id, iDBConn dBConn)
        {
            string CommandText = "SELECT * FROM Nail WHERE number =" + id;
            dBConn.open();
            Nail nail = getNailInformation(dBConn.executeRead(CommandText));
            dBConn.close();
            return nail;
        }
    }
}
