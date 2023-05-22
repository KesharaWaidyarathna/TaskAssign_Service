using Microsoft.AspNetCore.Mvc;
using TaskAssign.Models;
using TaskAssign.Service.Interfaces;


namespace TaskAssign.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class TaskController : ControllerBase
	{
		private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
			
			_taskService = taskService;

		}

        [HttpGet("GetTasks")]
		public async Task<IActionResult> GetTasks()
		{
			try
			{
				return Ok(await _taskService.GetTasks());
			}catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpGet("GetTaskById")]
		public async Task<IActionResult> GetTaskById(int taskId)
		{
			try
			{
				return Ok(await _taskService.GetTaskById(taskId));
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost("CreateTask")]
		public async Task<IActionResult> CreateTask([FromBody]task task)
		{
			try { 
				return Ok(await _taskService.CreateTask(task));
			}catch (Exception ex)
			{
				return BadRequest(ex.Message);

			}
		}

		[HttpPut("UpdateTask")]
		public async Task<IActionResult> UpdateTask([FromBody] task task)
		{
			try
			{
				return Ok(await _taskService.UpdateTask(task));
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpDelete("DeleteTask")]
		public async Task<IActionResult> DeleteTask(int taskId)
		{
			try
			{
				return Ok(await _taskService.DeleteTask(taskId));
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

	}
}
