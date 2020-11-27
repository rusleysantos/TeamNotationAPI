using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Adiciona_Execution_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectidProject",
                table: "Task",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Task_ProjectidProject",
                table: "Task",
                column: "ProjectidProject");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Project_ProjectidProject",
                table: "Task",
                column: "ProjectidProject",
                principalTable: "Project",
                principalColumn: "idProject",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Project_ProjectidProject",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_ProjectidProject",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "ProjectidProject",
                table: "Task");
        }
    }
}
