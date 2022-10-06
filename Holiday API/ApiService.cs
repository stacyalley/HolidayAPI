using Holiday_API.Models;
using System;
using System.Linq;

namespace Holiday_API
{
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
                    .Where(x => x.Holiday_date == dt.ToString("yyyy-MM-dd"))
                    .ToList<FedHolidayDate>()
                    .FirstOrDefault();

                //if the date was not a holiday date then bail out
                if(fhd is null) {return null;}

                var fh = dataContext
                        .FedHolidays
                        .Where(x => x.FedHolidayID
                        .Equals(fhd.FedHolidayID))
                        .FirstOrDefault<FedHoliday>();

                return fh;
            }               
     
        }

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
