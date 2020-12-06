using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Adiciona_Project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Project_ProjectidProject",
                table: "ProjectUser");

            migrationBuilder.DropIndex(
                name: "IX_ProjectUser_ProjectidProject",
                table: "ProjectUser");

            migrationBuilder.DropColumn(
                name: "ProjectidProject",
                table: "ProjectUser");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_IDPROJECT",
                table: "ProjectUser",
                column: "IDPROJECT");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_IDUSER",
                table: "ProjectUser",
                column: "IDUSER");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_Project_IDPROJECT",
                table: "ProjectUser",
                column: "IDPROJECT",
                principalTable: "Project",
                principalColumn: "IDPROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_User_IDUSER",
                table: "ProjectUser",
                column: "IDUSER",
                principalTable: "User",
                principalColumn: "IDUSER",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Project_IDPROJECT",
                table: "ProjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_User_IDUSER",
                table: "ProjectUser");

            migrationBuilder.DropIndex(
                name: "IX_ProjectUser_IDPROJECT",
                table: "ProjectUser");

            migrationBuilder.DropIndex(
                name: "IX_ProjectUser_IDUSER",
                table: "ProjectUser");

            migrationBuilder.AddColumn<int>(
                name: "ProjectidProject",
                table: "ProjectUser",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectidProject",
                table: "ProjectUser",
                column: "ProjectidProject");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_Project_ProjectidProject",
                table: "ProjectUser",
                column: "ProjectidProject",
                principalTable: "Project",
                principalColumn: "IDPROJECT",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
