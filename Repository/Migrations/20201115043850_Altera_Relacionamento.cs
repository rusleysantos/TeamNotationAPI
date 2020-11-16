using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Altera_Relacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_Project_ProjectidProject",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_ProjectidProject",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ProjectidProject",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Team_ProjectidProject",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "ProjectidProject",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProjectidProject",
                table: "Team");

            migrationBuilder.CreateTable(
                name: "ProjectTeam",
                columns: table => new
                {
                    idProjectTeam = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectidProject = table.Column<int>(nullable: true),
                    TeamidTeam = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTeam", x => x.idProjectTeam);
                    table.ForeignKey(
                        name: "FK_ProjectTeam_Project_ProjectidProject",
                        column: x => x.ProjectidProject,
                        principalTable: "Project",
                        principalColumn: "idProject",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectTeam_Team_TeamidTeam",
                        column: x => x.TeamidTeam,
                        principalTable: "Team",
                        principalColumn: "idTeam",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    idProjectUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectidProject = table.Column<int>(nullable: true),
                    UseridUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => x.idProjectUser);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Project_ProjectidProject",
                        column: x => x.ProjectidProject,
                        principalTable: "Project",
                        principalColumn: "idProject",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectUser_User_UseridUser",
                        column: x => x.UseridUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeam_ProjectidProject",
                table: "ProjectTeam",
                column: "ProjectidProject");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeam_TeamidTeam",
                table: "ProjectTeam",
                column: "TeamidTeam");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectidProject",
                table: "ProjectUser",
                column: "ProjectidProject");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UseridUser",
                table: "ProjectUser",
                column: "UseridUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTeam");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.AddColumn<int>(
                name: "ProjectidProject",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectidProject",
                table: "Team",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_ProjectidProject",
                table: "User",
                column: "ProjectidProject");

            migrationBuilder.CreateIndex(
                name: "IX_Team_ProjectidProject",
                table: "Team",
                column: "ProjectidProject");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Project_ProjectidProject",
                table: "Team",
                column: "ProjectidProject",
                principalTable: "Project",
                principalColumn: "idProject",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_ProjectidProject",
                table: "User",
                column: "ProjectidProject",
                principalTable: "Project",
                principalColumn: "idProject",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
