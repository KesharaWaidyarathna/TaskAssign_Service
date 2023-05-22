using Microsoft.EntityFrameworkCore;
using TaskAssign.Data.Interfaces;
using TaskAssign.DB;
using TaskAssign.Models;

namespace TaskAssign.Data.Repositories
{
	public class HolidayRepository : IHolidayRepository
	{
		private readonly ApplicationDbContext _context;
		public HolidayRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Holiday>> GetHolidays()
		{
			try
			{
				return await _context.Holidays.ToListAsync();
			}
			catch 
			{
				throw;
			}
		}
	}
}
