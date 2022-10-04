using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Holiday_API.Models
{
    public class FedHolidayDate
    {
        [Key]
        public int FedHolidayDateID { get; set; }
        public string Holiday_date { get; set; }



        public Nullable<int> FedHolidayID { get; set; }


        [ForeignKey("FedHolidayID")]
        public FedHoliday FedHoliday { get; set; }

    }
}
