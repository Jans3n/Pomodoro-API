using Microsoft.EntityFrameworkCore;
using Pomodoro.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Pomodoro.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Tasks> Tasks { get; set; }
    public DbSet<Users> AppUsers { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tasks>().ToTable("tasks");
            modelBuilder.Entity<Tasks>().Property(t => t.Id).HasColumnName("id");
            modelBuilder.Entity<Tasks>().Property(t => t.TaskDescription).HasColumnName("taskdescription");
            modelBuilder.Entity<Tasks>().Property(t => t.Pomodoros).HasColumnName("pomodoros");
            modelBuilder.Entity<Tasks>().Property(t => t.PomodorosPassed).HasColumnName("pomodorospassed");
            modelBuilder.Entity<Tasks>().Property(t => t.IsComplete).HasColumnName("iscomplete");

            modelBuilder.Entity<Users>().ToTable("users");
            modelBuilder.Entity<Users>().Property(t => t.Id).HasColumnName("id");
            modelBuilder.Entity<Users>().Property(t => t.Name).HasColumnName("name");
            modelBuilder.Entity<Users>().Property(t => t.Email).HasColumnName("email");
            modelBuilder.Entity<Users>().Property(t => t.Password).HasColumnName("password");
        }
    }

}
