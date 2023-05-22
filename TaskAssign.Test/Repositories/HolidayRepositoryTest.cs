using FakeItEasy;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using TaskAssign.Data.Repositories;
using TaskAssign.DB;
using TaskAssign.Models;

namespace TaskAssign.Test.Repositories
{

	public class HolidayRepositoryTest
	{
		private readonly ApplicationDbContext _context;
		private readonly HolidayRepository _holidayRepository;
		public HolidayRepositoryTest()
        {
			var options = new DbContextOptionsBuilder<ApplicationDbContext>()
		  .UseSqlServer("Server=localhost;Database=TaskAssign;Trusted_Connection=true;TrustServerCertificate=True")
		  .Options;
			_context = new ApplicationDbContext(options);
			_holidayRepository = new HolidayRepository(_context);
		}

		[Fact]
		public async Task Holiday_GetAllHolidays_HolidayObj()
		{
			//Arrage
			//Act
			var result = await _holidayRepository.GetHolidays();
			//Assert
			result.Should().NotBeNull();
			result.Should().HaveCount(12);
			result.Should().NotBeOfType<TeamMember>();
			result.Should().AllBeOfType<Holiday>();
		}

	}
}
