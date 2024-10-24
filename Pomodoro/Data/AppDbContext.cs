using Microsoft.EntityFrameworkCore;
using Pomodoro.Models;

namespace Pomodoro.Data
{
    public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Tasks> Tasks { get; set; }
    public DbSet<Users> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the Tasks table
        modelBuilder.Entity<Tasks>().ToTable("tasks");
        modelBuilder.Entity<Tasks>().Property(t => t.Id).HasColumnName("id");
        modelBuilder.Entity<Tasks>().Property(t => t.TaskDescription).HasColumnName("taskdescription");
        modelBuilder.Entity<Tasks>().Property(t => t.Pomodoros).HasColumnName("pomodoros");
        modelBuilder.Entity<Tasks>().Property(t => t.PomodorosPassed).HasColumnName("pomodorospassed");
        modelBuilder.Entity<Tasks>().Property(t => t.IsComplete).HasColumnName("iscomplete");
    }
    }

}
