using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Adiciona_Project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_Project_ProjectidProject",
                table: "PROJECT_USER");

            migrationBuilder.DropIndex(
                name: "IX_PROJECT_USER_ProjectidProject",
                table: "PROJECT_USER");

            migrationBuilder.DropColumn(
                name: "ProjectidProject",
                table: "PROJECT_USER");

            migrationBuilder.CreateIndex(
                name: "IX_PROJECT_USER_IDPROJECT",
                table: "PROJECT_USER",
                column: "IDPROJECT");

            migrationBuilder.CreateIndex(
                name: "IX_PROJECT_USER_IDUSER",
                table: "PROJECT_USER",
                column: "IDUSER");

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_USER_Project_IDPROJECT",
                table: "PROJECT_USER",
                column: "IDPROJECT",
                principalTable: "Project",
                principalColumn: "IDPROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_USER_User_IDUSER",
                table: "PROJECT_USER",
                column: "IDUSER",
                principalTable: "User",
                principalColumn: "IDUSER",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_Project_IDPROJECT",
                table: "PROJECT_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_User_IDUSER",
                table: "PROJECT_USER");

            migrationBuilder.DropIndex(
                name: "IX_PROJECT_USER_IDPROJECT",
                table: "PROJECT_USER");

            migrationBuilder.DropIndex(
                name: "IX_PROJECT_USER_IDUSER",
                table: "PROJECT_USER");

            migrationBuilder.AddColumn<int>(
                name: "ProjectidProject",
                table: "PROJECT_USER",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PROJECT_USER_ProjectidProject",
                table: "PROJECT_USER",
                column: "ProjectidProject");

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_USER_Project_ProjectidProject",
                table: "PROJECT_USER",
                column: "ProjectidProject",
                principalTable: "Project",
                principalColumn: "IDPROJECT",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
