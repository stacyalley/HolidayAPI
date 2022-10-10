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

        [ForeignKey("FedHolidayID")]
        public int FedHolidayID { get; set; }
        
        public virtual FedHoliday FedHoliday { get; set; }

    }
}
