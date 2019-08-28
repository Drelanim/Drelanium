using Microsoft.Extensions.Configuration;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var configroot = new ConfigurationBuilder()
                .AddJsonFile(@"C:\Nyiri_Attila\source\nyiriattila88\Drelanium\XUnitTestProject1\json1.json")
                .Build();


            var sauceconfig = new SauceLabsConfiguration();


            var config = new Config();


            configroot.Bind(config);
            configroot.Bind(sauceconfig);
        }
    }
}