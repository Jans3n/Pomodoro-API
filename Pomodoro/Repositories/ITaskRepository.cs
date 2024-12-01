using Pomodoro.Models;

namespace Pomodoro.Repositories
{
    public interface ITaskRepository
    {
        Task<List<Tasks>> GetAllTasksAsync();
        Task<Tasks> GetTaskByIdAsync(int id);
        Task AddTaskAsync(Tasks task);
        Task UpdateTaskAsync(Tasks task);
        Task DeleteTaskAsync(int id);
        Task UpdateTaskCompletionStatusAsync(int id, bool isComplete);
        Task IncrementPomodorosPassedAsync();
    }
}
