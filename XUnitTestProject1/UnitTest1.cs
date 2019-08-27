using Microsoft.Extensions.Configuration;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var configroot = new ConfigurationBuilder()
                .AddJsonFile(@"C:\Repos\Drelanium\XUnitTestProject1\json1.json").Build();
                


            var config = new Config();

                      


            configroot.Bind(config);






        }
    }
}
