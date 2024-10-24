using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pomodoro.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTaskTableNaming2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tasks",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "tasks",
                newName: "Id");
        }
    }
}
