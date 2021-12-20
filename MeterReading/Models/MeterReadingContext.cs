using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeterReadings.API.Models
{

    public class MeterReadingContext : DbContext
    {
        public MeterReadingContext()
        {

        }
        public MeterReadingContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<MeterReading> MeterReading { get; set; }
       public DbSet<Account> Account { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id = 1,
                    AccountId = 2344,
                    FirstName = "Tommy",
                    LastName = "Test"
                },
                new Account
                {
                    Id = 2,
                    AccountId = 2233,
                    FirstName = "Bany",
                    LastName = "Test"
                },
                new Account
                {
                    Id = 3,
                    AccountId = 8766,
                    FirstName = "Sally",
                    LastName = "Test"
                },
                new Account
                {
                    Id = 4,
                    AccountId = 2345,
                    FirstName = "Jerry",
                    LastName = "Test"
                },
                 new Account
                 {
                     Id = 5,
                     AccountId = 2345,
                     FirstName = "Jerry",
                     LastName = "Test"
                 },
                  new Account
                  {
                      Id = 6,
                      AccountId = 2345,
                      FirstName = "Jerry",
                      LastName = "Test"
                  },
                   new Account
                   {
                       Id = 7,
                       AccountId = 2345,
                       FirstName = "Jerry",
                       LastName = "Test"
                   },
                    new Account
                    {
                        Id = 8,
                        AccountId = 2345,
                        FirstName = "Jerry",
                        LastName = "Test"
                    },
                     new Account
                     {
                         Id = 9,
                         AccountId = 2346,
                         FirstName = "Ollie",
                         LastName = "Test"
                     },
                     new Account
                      {
                         Id = 10,
                         AccountId = 2347,
                          FirstName = "Tera",
                          LastName = "Test"
                      },
                     new Account
                     {
                         Id = 11,
                         AccountId = 2348,
                         FirstName = "Tammy",
                         LastName = "Test"
                     },
                       new Account
                       {
                           Id = 12,
                           AccountId = 2349,
                           FirstName = "Simon",
                           LastName = "Test"
                       },
                       new Account
                       {
                           Id = 13,
                           AccountId = 2350,
                           FirstName = "Colin",
                           LastName = "Test"
                       },
                       new Account
                       {
                           Id = 14,
                           AccountId = 2351,
                           FirstName = "Gladys",
                           LastName = "Test"
                       },
                        new Account
                        {
                            Id = 15,
                            AccountId = 2352,
                            FirstName = "Greg",
                            LastName = "Test"
                        }

            );
        }
    }

}
