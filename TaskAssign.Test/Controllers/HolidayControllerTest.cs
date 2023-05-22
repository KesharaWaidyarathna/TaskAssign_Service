using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using TaskAssign.Controllers;
using TaskAssign.Service.Interfaces;

namespace TaskAssign.Test.Controllers
{
	public class HolidayControllerTest
	{
		private readonly IHolidayService _holidayService;
		private readonly HolidayController _controller;

		public HolidayControllerTest()
        {
			_holidayService = A.Fake<IHolidayService>();
			_controller = new HolidayController(_holidayService);

		}

		[Fact]
		public  async Task Holiday_calculateCompleteDate_ReturnCompleteDate()
		{
			//Arrage
			string stratDate = "2023-05-22";
			int numberOfDay = 6;
			string completeDate = "2023-05-29";
			A.CallTo(() => _holidayService.calculateCompleteDate(stratDate, numberOfDay)).Returns(completeDate);

			//Act
			var actionResult = (OkObjectResult )await _controller.calculateCompleteDate(stratDate, numberOfDay);
			var result = actionResult.Value as string;

			//Assert
			result.Should().NotBeNull();
			result.Should().Be(completeDate);
			result.Should().NotBe("");
			result.Should().NotBe("null");
			result.Should().BeOfType<string>();
		}

	}
}
