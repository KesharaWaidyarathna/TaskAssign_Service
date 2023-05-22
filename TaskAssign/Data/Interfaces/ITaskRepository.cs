using TaskAssign.Models;

namespace TaskAssign.Data.Interfaces
{
	public interface ITaskRepository
	{
		Task<task> GetTaskById(int taskId);
		Task<List<task>> GetTasks();
		Task<bool> CreateTask(task task);
		Task<bool> UpdateTask(task task);
		Task<bool> DeleteTask(task task);
	}
}
