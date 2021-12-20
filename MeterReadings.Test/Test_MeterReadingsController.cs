using MeterReadings.API.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MeterReadings.Test
{
    [TestClass]
    public class Test_MeterReadingsController
    {

       
        [TestMethod]
        public async Task TestPostMeterReadings()
        {
            //Arrange
            var repositoryMock = new Mock<IMeterReadingRepository>();
            var fileMock = new Mock<IFormFile>();
            //Setup mock file using a memory stream
            int output = 0;
            var content = "Hello World from a Fake File";
            var fileName = "Meter_Reading.csv";
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            
            writer.Write(content);
            writer.Flush();
            ms.Position = 0;
            fileMock.Setup(_ => _.OpenReadStream()).Returns(ms);
            fileMock.Setup(_ => _.FileName).Returns(fileName);
            fileMock.Setup(_ => _.Length).Returns(ms.Length);
            var file = fileMock.Object;


            var controller = new API.Controllers.MeterReadingsController(repositoryMock.Object);
           

            //Act
            ActionResult<int> result = await controller.PostMeterReadings(file);

            //Assert
            Assert.IsInstanceOfType(result, typeof(ActionResult<int>));
            Assert.AreEqual(result.Value, output);

        }
        [TestMethod]
        public async Task TestPostMeterReadingsBadRequestError()
        {
            //Arrange
            var repositoryMock = new Mock<IMeterReadingRepository>();
            
            var controller = new API.Controllers.MeterReadingsController(repositoryMock.Object);


            //Act
            try
            {
                var result = await controller.PostMeterReadings(null);
            }
            catch (Exception ex)
            {
                //Assert
               
                Assert.IsTrue(ex.Message.Contains("File is empty"));
            }

        }

    }
    
}
