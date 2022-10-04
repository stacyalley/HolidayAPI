using Holiday_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Holiday_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HolidayController : ControllerBase
    {
        /// <summary>
        /// Returns Ok with the FedHolidayDate object if the input date was 
        /// found to be a federal holiday.
        /// Returns a 404 Not Found result for any input that was not found.
        /// </summary>
        /// <param name="queryDate"></param>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult Get(string queryDate)
        {

            FedHolidayDate hd = new FedHolidayDate();
            ApiService dataService = new ApiService();

            DateTime dt = dataService.CheckDateTime(queryDate);

            if(dt == default(DateTime))
            {
                return BadRequest();
            }
            hd = dataService.GetUsFedHolidayFromDB(dt);
            if(hd == null)
            {
                return NotFound();
            }

            return Ok(hd);
        }
    }
}
