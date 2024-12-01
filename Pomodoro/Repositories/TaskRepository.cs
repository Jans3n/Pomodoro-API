using Microsoft.EntityFrameworkCore;
using Pomodoro.Data;
using Pomodoro.Models;

namespace Pomodoro.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tasks>> GetAllTasksAsync()
        {
            return await _context.Tasks.OrderByDescending(t => t.Id).ToListAsync();
        }

        public async Task<Tasks> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task AddTaskAsync(Tasks task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTaskAsync(Tasks task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await GetTaskByIdAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateTaskCompletionStatusAsync(int id, bool isComplete)
        {
            var task = await GetTaskByIdAsync(id);
            if (task != null)
            {
                task.IsComplete = isComplete;
                await _context.SaveChangesAsync();
            }
        }

        public async Task IncrementPomodorosPassedAsync()
        {
            var tasks = await _context.Tasks.ToListAsync();

            foreach (var task in tasks)
            {
                task.PomodorosPassed++;
            }
            await _context.SaveChangesAsync();
        }
        
    }
}
