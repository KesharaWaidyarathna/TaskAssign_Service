using Microsoft.EntityFrameworkCore;
using TaskAssign.Data.Interfaces;
using TaskAssign.DB;
using TaskAssign.Models;

namespace TaskAssign.Data.Repositories
{
	public class TaskRepository: ITaskRepository
	{

		private readonly ApplicationDbContext _context;

		public TaskRepository(ApplicationDbContext context)
		{
            _context = context;
        }

		public async Task<bool> CreateTask(task task)
		{
			try
			{
				_context.Tasks.Add(task);
				await _context.SaveChangesAsync();
				return true;
			}
			catch
			{
				throw;
			}
		}

		public async Task<bool> DeleteTask(task task)
		{
			try { 
			_context.Tasks.Remove(task);
			await  _context.SaveChangesAsync();
			return true;
			}
			catch
			{
				throw;
			}
		}

		public async Task<task> GetTaskById(int taskId)
		{
			try
			{
				return await _context.Tasks.Include(x => x.teamMember).FirstOrDefaultAsync(t => t.Id == taskId);
			}
			catch
			{
				throw;
			}
		}

		public async Task<List<task>> GetTasks()
		{
			try
			{
				return await _context.Tasks.Include(x=>x.teamMember).ToListAsync();
			}
			catch
			{
				throw;
			}
		}

		public async Task<bool> UpdateTask(task task)
		{
			try
			{
				_context.Tasks.Update(task);
				await _context.SaveChangesAsync();
				return true;
			}
			catch
			{
				throw;
			}
		}
	}
}
