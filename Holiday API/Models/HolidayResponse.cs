namespace Holiday_API.Models
{
    public class HolidayResponse
    {
        public bool IsHoliday { get; set; } = false;
        public string HolidayName { get; set; }
        public string HolidayDescription { get; set; } 
        public bool IsFixed { get; set; }
        

    }
}
