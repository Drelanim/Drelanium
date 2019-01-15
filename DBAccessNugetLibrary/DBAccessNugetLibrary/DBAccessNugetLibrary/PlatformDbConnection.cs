using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccessNugetLibrary
{
    // Class used to create and open SQL connections to the a platform database which is associated 
    // with the current build configuration of the application that instantiates this class.
    //
    // the user must have the following keys defined in their app config files, e.g. based on current SKS test DB
    //  <appSettings>
    //      <!-- DATABASE ACCESS -->
    //      <add key = "platformDbServer" value="BGD-DEV-SQL" xdt:Transform="Replace" xdt:Locator="Match(key)"/>
    //      <add key = "platformDbServerUser" value="t.marosi-gs" xdt:Transform="Replace" xdt:Locator="Match(key)"/>
    //      <add key = "platformDbServerPwd" value="HNOUOY@!8X" xdt:Transform="Replace" xdt:Locator="Match(key)"/>
    //  </appSettings>
    //
    public class PlatformDbConnection
    {
        private SqlConnection _conn;
        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public PlatformDbConnection(string dbName)
        {
            string platformDbServer = ConfigurationManager.AppSettings["platformDbServer"]; 
            string platformDbServerUser = ConfigurationManager.AppSettings["platformDbServerUser"];
            string platformDbServerPwd = ConfigurationManager.AppSettings["platformDbServerPwd"];
            string connString = $"Data Source={platformDbServer};Initial Catalog={dbName};User ID={platformDbServerUser};Password={platformDbServerPwd}";
            this.Conn = new SqlConnection(connString);
            Console.WriteLine($"Opening database using: \"{connString}\"");
            Conn.Open();
        }

        public SqlDataReader SqlDataQuery(string queryString)
        {
            var cmd = new SqlCommand(queryString, this.Conn);
            Console.WriteLine($"issueing data query: \"{queryString}\"");
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
    }
}
