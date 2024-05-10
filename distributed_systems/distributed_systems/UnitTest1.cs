using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace distributed_systems
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("hello world from mike and " + new HelloWorld().GetName());
        }
    }
}
