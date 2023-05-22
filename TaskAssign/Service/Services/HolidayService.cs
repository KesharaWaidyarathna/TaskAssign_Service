using Newtonsoft.Json;
using TaskAssign.Data.Interfaces;
using TaskAssign.Models;
using TaskAssign.Service.Interfaces;

namespace TaskAssign.Service.Services
{
	public class HolidayService: IHolidayService
	{
		private readonly IHolidayRepository _holidayRepository;
		public HolidayService(IHolidayRepository holidayRepository) {
		
			_holidayRepository = holidayRepository;
		}

		public async Task<string> calculateCompleteDate(string date,int numberOfDays)
		{
			try
			{
				string startDateString = date;
				int daysAdded = 1;
				DateTime startDate = DateTime.Parse(startDateString);

				List<Holiday> holidays = await _holidayRepository.GetHolidays();
				while (daysAdded < numberOfDays)
				{
					startDate = startDate.AddDays(1);

					// Check if the current date is a weekend or holiday
					if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday && !holidays.Any(x => x.HoliyDay.Date == startDate))
					{
						daysAdded++;
					}
				}

				return JsonConvert.SerializeObject(startDate.ToString("yyyy-MM-dd"));
			}
			catch
			{
				throw;
			}
		}
	}
}
