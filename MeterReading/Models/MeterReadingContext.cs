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
        public MeterReadingContext(DbContextOptions<MeterReadingContext> options) : base(options)
        {

        }
        public DbSet<MeterReading> MeterReading { get; set; }
       public DbSet<Account> Account { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Account>().HasData(
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

            );
        }
    }

}
