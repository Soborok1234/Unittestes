using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Unittestes;

namespace databaseunittests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingConnection_ReturnedTrue()
        {
            using (DataBase dataBase = new DataBase())
            {
                Assert.IsTrue(dataBase.IsConnected);
               
            }
        }
    }
}
