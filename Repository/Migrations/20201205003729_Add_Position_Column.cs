using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Add_Position_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Project_ProjectidProject",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Status_StatusidStatus",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_UseridUser",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_ProjectidProject",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_StatusidStatus",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_UseridUser",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "ProjectidProject",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "StatusidStatus",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "UseridUser",
                table: "Task");

            migrationBuilder.AddColumn<int>(
                name: "ProjectidProject1",
                table: "Task",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusidStatus1",
                table: "Task",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UseridUser1",
                table: "Task",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Task_ProjectidProject1",
                table: "Task",
                column: "ProjectidProject1");

            migrationBuilder.CreateIndex(
                name: "IX_Task_StatusidStatus1",
                table: "Task",
                column: "StatusidStatus1");

            migrationBuilder.CreateIndex(
                name: "IX_Task_UseridUser1",
                table: "Task",
                column: "UseridUser1");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Project_ProjectidProject1",
                table: "Task",
                column: "ProjectidProject1",
                principalTable: "Project",
                principalColumn: "idProject",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Status_StatusidStatus1",
                table: "Task",
                column: "StatusidStatus1",
                principalTable: "Status",
                principalColumn: "idStatus",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_UseridUser1",
                table: "Task",
                column: "UseridUser1",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Project_ProjectidProject1",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Status_StatusidStatus1",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_UseridUser1",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_ProjectidProject1",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_StatusidStatus1",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_UseridUser1",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "ProjectidProject1",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "StatusidStatus1",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "UseridUser1",
                table: "Task");

            migrationBuilder.AddColumn<int>(
                name: "ProjectidProject",
                table: "Task",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusidStatus",
                table: "Task",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UseridUser",
                table: "Task",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Task_ProjectidProject",
                table: "Task",
                column: "ProjectidProject");

            migrationBuilder.CreateIndex(
                name: "IX_Task_StatusidStatus",
                table: "Task",
                column: "StatusidStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Task_UseridUser",
                table: "Task",
                column: "UseridUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Project_ProjectidProject",
                table: "Task",
                column: "ProjectidProject",
                principalTable: "Project",
                principalColumn: "idProject",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Status_StatusidStatus",
                table: "Task",
                column: "StatusidStatus",
                principalTable: "Status",
                principalColumn: "idStatus",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_UseridUser",
                table: "Task",
                column: "UseridUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
