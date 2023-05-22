using Microsoft.AspNetCore.Mvc;
using TaskAssign.Service.Interfaces;

namespace TaskAssign.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HolidayController : ControllerBase
	{
		private readonly IHolidayService _holidayService;
        public HolidayController(IHolidayService holidayService)
        {
            _holidayService = holidayService;
        }
        [HttpGet("calculateCompleteDate")]
		public async Task<IActionResult> calculateCompleteDate(string stratDate,int numberOfDays)
		{
			try
			{
				return Ok( await _holidayService.calculateCompleteDate(stratDate, numberOfDays));

			}
			catch (Exception ex) 
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
