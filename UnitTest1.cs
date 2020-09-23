using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks.Dataflow;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(DAL.UserInfo.Instance.UserCheck("Admin"));

        }
    }
}
