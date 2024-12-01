using Pomodoro.Models;
using Pomodoro.Repositories;

namespace Pomodoro.Services
{
    public class TaskService : ITaskService
    {
        public readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<Tasks>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllTasksAsync();
        }

        public async Task<Tasks> GetTaskByIdAsync(int id)
        {
            return await _taskRepository.GetTaskByIdAsync(id);
        }

        public async Task AddTaskAsync(Tasks task)
        {
            await _taskRepository.AddTaskAsync(task);
        }

        public async Task UpdateTaskAsync(Tasks task)
        {
            await _taskRepository.UpdateTaskAsync(task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteTaskAsync(id);
        }

        public async Task UpdateTaskCompletionStatusAsync(int id, bool isCompelete)
        {
            var task = await _taskRepository.GetTaskByIdAsync(id);
            if (task == null)
            {
                throw new Exception("Task not found");
            }

            await _taskRepository.UpdateTaskCompletionStatusAsync(id, isCompelete);
        }

        public async Task IncrementPomodorosPassedAsync()
        {
            await _taskRepository.IncrementPomodorosPassedAsync();
        }

    }
}
