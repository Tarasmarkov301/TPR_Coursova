using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursovaSaleOfNail.Data.Interfaces;
using CoursovaSaleOfNail.Data.Models.BDModel;
using System.Data.Odbc;

namespace CoursovaSaleOfNail.Data.Mock
{
    public class RWSale : iRWSale
    { 
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
        private int getIntFromReader(OdbcDataReader reader)
        {
            reader.Read();
            return reader.GetInt32(0);
        }

        public IEnumerable<Nail> saleByType(string nameOfClient, int num, iDBConn dBConn)
        {
            string CommandText = "SELECT * from Nail inner join Sale on Nail.number = Sale.numberOfNale WHERE typeOf =" + num +" and nameOfCient ='" + nameOfClient + "'";
            dBConn.open();
            IEnumerable<Nail> nails = getNailsInformation(dBConn.executeRead(CommandText));
            dBConn.close();
            return nails;
        }

        public bool setSale(int numberOfNail, string clientName, iDBConn dBConn)
        {
            string CommandText = "SELECT max(numberOfSale) from Sale";
            dBConn.open();
            int numberOfSail = getIntFromReader(dBConn.executeRead(CommandText)) + 1;
            CommandText = "INSERT INTO [dbo].[Sale]([numberOfSale], [numberOfNale], [nameOfCient], [typeOf]) VALUES (" + numberOfSail + "," + numberOfNail + ", '" + clientName + "', 1)";
            bool ok = dBConn.executeNon(CommandText);
            dBConn.close();
            return true;
        }
    }
}
