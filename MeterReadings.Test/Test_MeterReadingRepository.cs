using MeterReadings.API.DAL;
using MeterReadings.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace MeterReadings.Tests
{
   [TestClass]
    public class Test_MeterReadingRepository
    {


        IMeterReadingRepository _repository;
      
       [TestInitialize]
       public void Setup()
        {
            _repository = GetInMemoryReposity();
        }

        private IMeterReadingRepository GetInMemoryReposity()
        {
            var options = new DbContextOptionsBuilder<MeterReadingContext>()
                .UseInMemoryDatabase("MockDB")
                .Options;
            var context = new MeterReadingContext(options);
            var account = new List<Account>
            {
               new Account
               {

                   AccountId = 2344,
                   FirstName = "Tommy",
                   LastName = "Test"
               },
               new Account
               {

                   AccountId = 2233,
                   FirstName = "Bany",
                   LastName = "Test"
               },
               new Account
               {

                   AccountId = 8766,
                   FirstName = "Sally",
                   LastName = "Test"
               },
               new Account
               {

                   AccountId = 2345,
                   FirstName = "Jerry",
                   LastName = "Test"
               },
                new Account
                {

                    AccountId = 2346,
                    FirstName = "Jerry",
                    LastName = "Test"
                },
                 new Account
                 {

                     AccountId = 2347,
                     FirstName = "Jerry",
                     LastName = "Test"
                 },
                  new Account
                  {

                      AccountId = 2348,
                      FirstName = "Jerry",
                      LastName = "Test"
                  },
                   new Account
                   {

                       AccountId = 2349,
                       FirstName = "Jerry",
                       LastName = "Test"
                   },
                    new Account
                    {

                        AccountId = 2350,
                        FirstName = "Ollie",
                        LastName = "Test"
                    },
                    new Account
                    {

                        AccountId = 2351,
                        FirstName = "Tera",
                        LastName = "Test"
                    },
                    new Account
                    {

                        AccountId = 2352,
                        FirstName = "Tammy",
                        LastName = "Test"
                    },
                      new Account
                      {

                          AccountId = 2353,
                          FirstName = "Simon",
                          LastName = "Test"
                      },
                      new Account
                      {

                          AccountId = 2355,
                          FirstName = "Colin",
                          LastName = "Test"
                      },
                      new Account
                      {

                          AccountId = 2356,
                          FirstName = "Gladys",
                          LastName = "Test"
                      },
                      new Account
                      {

                          AccountId = 6776,
                          FirstName = "Greg",
                          LastName = "Test"
                      }
            };

            context.AddRange(account);
            context.SaveChanges();
            var repository = new MeterReadingRepository(context);
            return repository;
        }

        [TestMethod]
        public async Task UploadMeterReadingAsync()
        {
                     
            var response = await _repository.UploadMeterReadingAsync("Meter_Reading.csv");
            Assert.AreEqual(response, 3);
            
        }
    }
}
