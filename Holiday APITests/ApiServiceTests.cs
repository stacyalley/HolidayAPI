using Microsoft.VisualStudio.TestTools.UnitTesting;
using Holiday_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Holiday_API.Models;
using System.Text.Json.Serialization.Metadata;

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

        [TestMethod()]
        public void GetHolidayResponseTest()
        {
            //Arrange
            FedHoliday th = new FedHoliday {
                Holiday_name="Holiday One", 
                Holiday_descr="Holiday description 1", 
                Is_fixed=true,
            };
            ApiService service = new ApiService();
           
            //Act
            HolidayResponse thr = service.GetHolidayResponse(th);      

            //Assert
            Assert.AreEqual(th.Holiday_name, thr.HolidayName);
            Assert.AreEqual(th.Holiday_descr, thr.HolidayDescription);
            Assert.AreEqual(th.Is_fixed, thr.IsFixed);
        }
    }
}