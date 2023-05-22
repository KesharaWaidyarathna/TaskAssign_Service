using TaskAssign.Models;

namespace TaskAssign.Service.Interfaces
{
	public interface ITaskService
	{
		Task<task> GetTaskById(int taskId);
		Task<List<task>> GetTasks();
		Task<bool> CreateTask(task task);
		Task<bool> UpdateTask(task task);
		Task<bool> DeleteTask(int taskId);
	}
}
