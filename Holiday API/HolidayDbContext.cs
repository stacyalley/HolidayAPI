using Holiday_API.Models;
using Microsoft.EntityFrameworkCore;


namespace Holiday_API
{
    public class HolidayDbContext : DbContext
    {
        public virtual DbSet<FedHolidayDate> FedHolidayDates { get; set; }
        public virtual DbSet<FedHoliday> FedHolidays { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=usFedHolidays.db");  
        }   
    }    
}
