using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class adiciona_sequene_number : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SEQUENCE_NUMBER",
                table: "EXECUTION_TASK",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SEQUENCE_NUMBER",
                table: "EXECUTION_TASK");
        }
    }
}
