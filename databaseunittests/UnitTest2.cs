using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;
using Unittestes;

namespace databaseunittests
{
    [TestClass]
    public class UnitTest2
    {
        [TestCase("+7-123-456-78-90", ExpectedResult = true)]
        [TestCase("7-123-456-78-90", ExpectedResult = false)]

        public bool IsPhoneNumberValid_ShouldReturnExpectedResult(string phoneNumber)
        {

            string pattern = @"^\+?\d{1,3}?[- .]?\(?(?:\d{2,3})\)?[- .]?\d\d\d[- .]?\d\d[- .]?\d\d$";

            if (Regex.IsMatch(phoneNumber, pattern))
            {
                return true;
            }
            else { return false; }

        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
