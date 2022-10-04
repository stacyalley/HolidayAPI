using Microsoft.VisualStudio.TestTools.UnitTesting;
using Holiday_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_API.Tests
{
    [TestClass()]
    public class ApiServiceTests
    {
        [TestMethod()]
        public void CheckDateTimeTest_BadDate()
        {
            //Arrange
            String badDate = "abcd";
            ApiService dataService = new ApiService();

            //Act
            DateTime testDate = dataService.CheckDateTime(badDate);

            //Assert
            Assert.AreEqual(testDate, default(DateTime));

        }

        [TestMethod]
        public void CheckDateTimeTest_GoodDate()
        {
            //Arrange
            String goodDate = "2021-01-20";
            ApiService dataService = new ApiService();

            //Act
            DateTime testDate = dataService.CheckDateTime(goodDate);    

            //Assert
            Assert.AreNotEqual(testDate, default(DateTime));    
        }
    }
}