using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using lkhassignment;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            menu menu = new menu();
            //Act
            ViewResult result = menu as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
