using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Adiciona_Sprint_Link_Task_Notation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SprintidSprint",
                table: "USER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamidTeam",
                table: "USER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_TEAM",
                table: "PROJECT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COLOR_BACKGROUND",
                table: "EXECUTION_TASK",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COLOR_TEXT",
                table: "EXECUTION_TASK",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COLOR_BACKGROUND",
                table: "ANNOTATION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COLOR_TEXT",
                table: "ANNOTATION",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExecutionTaskidTask",
                table: "ANNOTATION",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SPRINT",
                columns: table => new
                {
                    ID_SPRINT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(nullable: true),
                    GOAL = table.Column<string>(nullable: true),
                    START = table.Column<DateTime>(nullable: false),
                    END = table.Column<DateTime>(nullable: false),
                    ProjectidProject = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPRINT", x => x.ID_SPRINT);
                    table.ForeignKey(
                        name: "FK_SPRINT_PROJECT_ProjectidProject",
                        column: x => x.ProjectidProject,
                        principalTable: "PROJECT",
                        principalColumn: "ID_PROJECT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_USER_SprintidSprint",
                table: "USER",
                column: "SprintidSprint");

            migrationBuilder.CreateIndex(
                name: "IX_USER_TeamidTeam",
                table: "USER",
                column: "TeamidTeam");

            migrationBuilder.CreateIndex(
                name: "IX_PROJECT_ID_TEAM",
                table: "PROJECT",
                column: "ID_TEAM");

            migrationBuilder.CreateIndex(
                name: "IX_ANNOTATION_ExecutionTaskidTask",
                table: "ANNOTATION",
                column: "ExecutionTaskidTask");

            migrationBuilder.CreateIndex(
                name: "IX_SPRINT_ProjectidProject",
                table: "SPRINT",
                column: "ProjectidProject");

            migrationBuilder.AddForeignKey(
                name: "FK_ANNOTATION_EXECUTION_TASK_ExecutionTaskidTask",
                table: "ANNOTATION",
                column: "ExecutionTaskidTask",
                principalTable: "EXECUTION_TASK",
                principalColumn: "ID_TASK",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_TEAM_ID_TEAM",
                table: "PROJECT",
                column: "ID_TEAM",
                principalTable: "TEAM",
                principalColumn: "ID_TEAM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_SPRINT_SprintidSprint",
                table: "USER",
                column: "SprintidSprint",
                principalTable: "SPRINT",
                principalColumn: "ID_SPRINT",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_TEAM_TeamidTeam",
                table: "USER",
                column: "TeamidTeam",
                principalTable: "TEAM",
                principalColumn: "ID_TEAM",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ANNOTATION_EXECUTION_TASK_ExecutionTaskidTask",
                table: "ANNOTATION");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_TEAM_ID_TEAM",
                table: "PROJECT");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_SPRINT_SprintidSprint",
                table: "USER");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_TEAM_TeamidTeam",
                table: "USER");

            migrationBuilder.DropTable(
                name: "SPRINT");

            migrationBuilder.DropIndex(
                name: "IX_USER_SprintidSprint",
                table: "USER");

            migrationBuilder.DropIndex(
                name: "IX_USER_TeamidTeam",
                table: "USER");

            migrationBuilder.DropIndex(
                name: "IX_PROJECT_ID_TEAM",
                table: "PROJECT");

            migrationBuilder.DropIndex(
                name: "IX_ANNOTATION_ExecutionTaskidTask",
                table: "ANNOTATION");

            migrationBuilder.DropColumn(
                name: "SprintidSprint",
                table: "USER");

            migrationBuilder.DropColumn(
                name: "TeamidTeam",
                table: "USER");

            migrationBuilder.DropColumn(
                name: "ID_TEAM",
                table: "PROJECT");

            migrationBuilder.DropColumn(
                name: "COLOR_BACKGROUND",
                table: "EXECUTION_TASK");

            migrationBuilder.DropColumn(
                name: "COLOR_TEXT",
                table: "EXECUTION_TASK");

            migrationBuilder.DropColumn(
                name: "COLOR_BACKGROUND",
                table: "ANNOTATION");

            migrationBuilder.DropColumn(
                name: "COLOR_TEXT",
                table: "ANNOTATION");

            migrationBuilder.DropColumn(
                name: "ExecutionTaskidTask",
                table: "ANNOTATION");
        }
    }
}
