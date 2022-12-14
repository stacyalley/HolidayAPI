using Holiday_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Holiday_API
{
    /// <summary>
    /// Services for returning US federal holiday data
    /// </summary>
    public class ApiService
    {
        /// <summary>
        /// Returns a FedHolidayDate object if the date passed in was a
        /// Federal Holiday.
        /// Sends the query via linq to avoid sending string based queries
        /// </summary>
        /// <param name="inputDate"></param>
        /// <returns>FedHolidayDate</returns>
        /// 
        public FedHoliday GetUsFedHolidayFromDB(DateTime dt)
        {
            using (HolidayDbContext dataContext = new HolidayDbContext())
            {

                var fhd = dataContext.FedHolidayDates
                    .Where(x=> x.Holiday_date == dt.ToString("yyyy-MM-dd"))
                    .Include(x=> x.FedHoliday)
                    .ToList<FedHolidayDate>()
                    .FirstOrDefault();
                return fhd.FedHoliday;

            }               
        }

        /// <summary>
        /// Returns a HolidayResponse
        /// </summary>
        /// <param name="hd"></param>
        /// <returns>HolidayResponse</returns>
        public HolidayResponse GetHolidayResponse(FedHoliday hd)
        {
            HolidayResponse hr = new HolidayResponse
            {
                HolidayDescription = hd.Holiday_descr,
                HolidayName = hd.Holiday_name,
                IsFixed = hd.Is_fixed,
                IsHoliday = true
            };
            return hr;

        }
            

        /// <summary>
        /// Returns a DateTime created by input string for requested date.
        /// If the input string is not a valid date, the DateTime passed back 
        /// will be the default value for the DateTime type.
        /// </summary>
        /// <param name="queryDate"></param>
        /// <returns>DateTime</returns>
        public DateTime CheckDateTime(string queryDate)
        {
            DateTime dt;
            DateTime.TryParse(queryDate, out dt);

            return dt;
        }
    }
}
