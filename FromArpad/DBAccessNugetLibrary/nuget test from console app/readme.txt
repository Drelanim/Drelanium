
Console app that uses the DBAccessNugetLibrary.1.0.0.nupkg package located in package source folder C:\nuget
Note that when importing the nuget we need to set up a local nuget source to this directory

The app config file needs to contain the database connection particulars:
  <appSettings>
    <!-- DATABASE ACCESS -->
    <add key="platformDbServer" value="BGD-DEV-SQL"/>
    <add key="platformDbServerUser" value="t.marosi-gs"/>
    <add key="platformDbServerPwd" value="HNOUOY@!8X"/>
  </appSettings>

And this is the code:

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

And this is the console output it produces:

	Opening database using: "Data Source=BGD-DEV-SQL;Initial Catalog=ISBets;User ID=t.marosi-gs;Password=HNOUOY@!8X"
	issueing data query: "SELECT [ID], [Name] FROM [ISBets].[Affiliati].[Products]"
	-------------------------------------------------------------------
 	id 1
 	name: Sport Betting
	-------------------------------------------------------------------
 	id 2
 	name: Casino