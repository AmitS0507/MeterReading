using CsvHelper;
using MeterReadings.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MeterReadings.ExceptionHandling.Exception;
using System.Text.RegularExpressions;

namespace MeterReadings.API.DAL
{
    public class MeterReadingRepository: IMeterReadingRepository
    {
        private readonly MeterReadingContext _context;
        public MeterReadingRepository(MeterReadingContext context)
        {
            _context = context;
        }

        public async Task<int> UploadMeterReadingAsync (string fileName)
        {
            int output = 0;
            if (!Path.GetExtension(fileName).Equals(".csv"))
            {
                throw new  DomainNotFoundException("File format is not correct");
            }

            using (TextReader fileReader = System.IO.File.OpenText(fileName))
            {
                var csv = new CsvReader(fileReader);
                csv.Configuration.HasHeaderRecord = true;
                csv.Configuration.HeaderValidated = null;
                csv.Configuration.MissingFieldFound = null;
                //Reading MeterReacords having 5 digits NNNNN
                var meterReadings = csv.GetRecords<MeterReading>().ToList().FindAll(s => Regex.IsMatch(s.MeterReadValue.ToString(), @"^\d{5}$"));
                foreach (var meterReading in meterReadings)
                {
                    //A meter reading must be associated with an Account ID to be deemed valid
                    if (_context.Account.AsNoTracking().Any(o => o.AccountId == meterReading.AccountId))
                    {
                        //Not to add same entry twice
                        
                        if (_context.MeterReading.AsNoTracking().Any(o => o.AccountId == meterReading.AccountId))
                        {

                            var modMeterReading = _context.MeterReading.FirstOrDefault(o => o.AccountId == meterReading.AccountId);
                            modMeterReading.AccountId = meterReading.AccountId;
                            modMeterReading.MeterReadingDateTime = meterReading.MeterReadingDateTime;
                            modMeterReading.MeterReadValue = meterReading.MeterReadValue;
                            
                            
                        }
                        else
                        {
                          
                            _context.MeterReading.Add(meterReading);
                     
                        }
                    }

                }

            }

            return output = await _context.SaveChangesAsync();
             

            
            
        }

    }
}
