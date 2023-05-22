using TaskAssign.Models;

namespace TaskAssign.Data.Interfaces
{
	public interface IHolidayRepository
	{
		Task<List<Holiday>> GetHolidays();
	}
}
