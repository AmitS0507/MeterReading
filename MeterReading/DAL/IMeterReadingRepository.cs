using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeterReadings.API.DAL
{
    public interface IMeterReadingRepository
    {
        Task<int> UploadMeterReadingAsync(string fileName);
    }
}
