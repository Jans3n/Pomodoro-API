using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pomodoro.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTaskTableNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "tasks");

            migrationBuilder.RenameColumn(
                name: "TaskDescription",
                table: "tasks",
                newName: "taskdescription");

            migrationBuilder.RenameColumn(
                name: "PomodorosPassed",
                table: "tasks",
                newName: "pomodorospassed");

            migrationBuilder.RenameColumn(
                name: "Pomodoros",
                table: "tasks",
                newName: "pomodoros");

            migrationBuilder.RenameColumn(
                name: "IsComplete",
                table: "tasks",
                newName: "iscomplete");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tasks",
                table: "tasks",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tasks",
                table: "tasks");

            migrationBuilder.RenameTable(
                name: "tasks",
                newName: "Tasks");

            migrationBuilder.RenameColumn(
                name: "taskdescription",
                table: "Tasks",
                newName: "TaskDescription");

            migrationBuilder.RenameColumn(
                name: "pomodorospassed",
                table: "Tasks",
                newName: "PomodorosPassed");

            migrationBuilder.RenameColumn(
                name: "pomodoros",
                table: "Tasks",
                newName: "Pomodoros");

            migrationBuilder.RenameColumn(
                name: "iscomplete",
                table: "Tasks",
                newName: "IsComplete");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");
        }
    }
}
