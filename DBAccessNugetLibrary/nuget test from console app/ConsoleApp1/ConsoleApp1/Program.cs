using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccessNugetLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var platformDbConnection = new PlatformDbConnection("ISBets");
            SqlDataReader rdr = platformDbConnection.SqlDataQuery("SELECT [ID], [Name] FROM [ISBets].[Affiliati].[Products]");
            while (rdr.Read())
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine(" id " + rdr["ID"]);
                Console.WriteLine(" name: " + rdr["Name"]);
            }

            Console.ReadKey();
        }
    }
}
