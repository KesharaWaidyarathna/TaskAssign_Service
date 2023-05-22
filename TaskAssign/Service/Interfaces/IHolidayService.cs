using TaskAssign.Models;

namespace TaskAssign.Service.Interfaces
{
	public interface IHolidayService
	{
		Task<string> calculateCompleteDate(string date, int numberOfDays);
	}
}
