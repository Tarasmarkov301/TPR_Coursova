using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Odbc;
using CoursovaSaleOfNail.Data.Interfaces;
namespace CoursovaSaleOfNail
{
    public class DBConn : iDBConn
    {
        static private readonly OdbcConnection connect = new OdbcConnection("Dsn=Nail");
        public void open()
        {
            DBConn.connect.Close();
            DBConn.connect.Open();
        }
        public OdbcDataReader executeRead(string commandText)
        {
            OdbcCommand myCommand = new OdbcCommand(commandText, DBConn.connect);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            OdbcDataReader myDataReader;
            myDataReader = myCommand.ExecuteReader();
            return myDataReader;
        }
        public bool executeNon(string commandText)
        {
            try
            {
                OdbcCommand myCommand = new OdbcCommand(commandText, DBConn.connect);
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }
        public void close()
        {
            connect.Close();
        }


    }
}
