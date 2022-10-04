using System.ComponentModel.DataAnnotations;

namespace Holiday_API.Models
{
    public class FedHoliday
    {
        [Key]
        public int FedHolidayID { get; set; }
        public string Holiday_name { get; set; }
        public string Holiday_descr { get; set; } 
        public bool Is_fixed { get; set; }

    }
}
