using System.ComponentModel.DataAnnotations;

namespace Pomodoro.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string? TaskDescription { get; set; }
        public int Pomodoros { get; set; }
        public int PomodorosPassed {  get; set; }
        public bool IsComplete {  get; set; }
    }
}
