using MeterReadings.API.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using MeterReadings.ExceptionHandling.Exception;

namespace MeterReadings.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterReadingsController : ControllerBase
    {
        private readonly IMeterReadingRepository _meterReadingRepository;

        public MeterReadingsController(IMeterReadingRepository meterReadingRepository)
        {
             _meterReadingRepository = meterReadingRepository;
        }


        [Route("meter-reading-uploads")]
        [HttpPost]
        public async Task<ActionResult> PostMeterReadings(IFormFile meterReadings)
        {


            if (meterReadings == null)
            {
                throw new DomainBadRequestException("File is empty");
            }

           
            return Ok("Number of successful processed records=" + await _meterReadingRepository.UploadMeterReadingAsync(meterReadings.FileName));
        }

      
    }
}
