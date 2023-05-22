using Newtonsoft.Json;
using System.Linq;
using TaskAssign.Data.Interfaces;
using TaskAssign.Models;
using TaskAssign.Service.Interfaces;

namespace TaskAssign.Service.Services
{
	public class TaskService : ITaskService
	{
		private readonly ITaskRepository _taskRepository;
		private readonly ITeamMemberRepository _teamMemberRepository;

        public TaskService(ITaskRepository taskRepository, ITeamMemberRepository teamMemberRepository)
        {
            _taskRepository = taskRepository;
			_teamMemberRepository = teamMemberRepository;

		}

		public async Task<bool> CreateTask(task task)
		{
			try
			{
				var member = await _teamMemberRepository.GetTeamMemberById(task.teamMember.Id);
				if (member != null) { task.teamMember = member; }
				return await _taskRepository.CreateTask(task); 
			}
			catch
			{
				throw;
			}
		}

		public async Task<bool> DeleteTask(int taskId)
		{
			try
			{
				var task = await _taskRepository.GetTaskById(taskId);
				return await _taskRepository.DeleteTask(task);
			}
			catch
			{
				throw;
			}
		}
		public async Task<task> GetTaskById(int taskId)
		{
			return await _taskRepository.GetTaskById(taskId);
		}

		public async Task<List<task>> GetTasks()
		{
			try
			{
				var tasks=await _taskRepository.GetTasks();
				if (tasks == null)
				{
					throw new KeyNotFoundException();
				}
				return tasks;
			}
			catch {

				throw;
			}
		}

		public Task<bool> UpdateTask(task task)
		{
			try
			{
				return _taskRepository.UpdateTask(task);

			}catch 
			{
				throw;
			}

		}
	}
}
