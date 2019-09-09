using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace XUnitTestProject1.Marci
{
    [My]
    public class TestClass
    {
        [Fact]
        public void MyTest()
        {
            foreach (var type in typeof(TestClass).Assembly.GetTypes()
                .Where(t => t.GetCustomAttribute<MyAttribute>() != null))
            {
                foreach (var method in type.GetMethods())
                {
                    Console.WriteLine(method.Name);
                }
            }
        }
    }
}