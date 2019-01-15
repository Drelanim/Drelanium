using System;
using System.Data.SqlClient;
using DBAccessNugetLibrary;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class TestPlatformDbConnectionClass
    {
        [TestCase("ISBets")]
        public void TestConstructor(string dbName)
        {
            var platformDbConnection = new PlatformDbConnection(dbName);
            Assert.AreEqual(System.Data.ConnectionState.Open, platformDbConnection.Conn.State, "Connection failed to open");
        }

        [TestCase("ISBets", "SELECT [ID], [Name] FROM [ISBets].[Affiliati].[Products]")]
        public void TestMethodSqlDataQuery(string dbName, string queryString)
        {
            var platformDbConnection = new PlatformDbConnection(dbName);
            Assert.AreEqual(System.Data.ConnectionState.Open, platformDbConnection.Conn.State, "Connection failed to open");
            SqlDataReader rdr = platformDbConnection.SqlDataQuery(queryString);
            int recordsFound = 0;
            while (rdr.Read())
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine(" id " + rdr["ID"]);
                Console.WriteLine(" name: " + rdr["Name"]);
                recordsFound++;
            }
            Assert.AreNotEqual(0, recordsFound, "no records found");           
        }       
    }
}
