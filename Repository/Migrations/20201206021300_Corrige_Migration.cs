using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Corrige_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExecutionTask_Project_ProjectidProject",
                table: "ExecutionTask");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_Project_IDPROJECT",
                table: "PROJECT_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_User_IDUSER",
                table: "PROJECT_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_IDADDRESS",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Profile_IDPROFILE",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_ExecutionTask_ProjectidProject",
                table: "ExecutionTask");

            migrationBuilder.DropColumn(
                name: "ProjectidProject",
                table: "ExecutionTask");

            migrationBuilder.RenameColumn(
                name: "IDPROFILE",
                table: "User",
                newName: "ID_PROFILE");

            migrationBuilder.RenameColumn(
                name: "IDADDRESS",
                table: "User",
                newName: "ID_ADDRESS");

            migrationBuilder.RenameColumn(
                name: "IDUSER",
                table: "User",
                newName: "ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_User_IDPROFILE",
                table: "User",
                newName: "IX_User_ID_PROFILE");

            migrationBuilder.RenameIndex(
                name: "IX_User_IDADDRESS",
                table: "User",
                newName: "IX_User_ID_ADDRESS");

            migrationBuilder.RenameColumn(
                name: "IDTEAM",
                table: "Team",
                newName: "ID_TEAM");

            migrationBuilder.RenameColumn(
                name: "IDSTATUS",
                table: "Status",
                newName: "ID_STATUS");

            migrationBuilder.RenameColumn(
                name: "IDUSER",
                table: "PROJECT_USER",
                newName: "ID_USER");

            migrationBuilder.RenameColumn(
                name: "IDPROJECT",
                table: "PROJECT_USER",
                newName: "ID_PROJECT");

            migrationBuilder.RenameColumn(
                name: "IDPROJECT_USER",
                table: "PROJECT_USER",
                newName: "ID_PROJECT_USER");

            migrationBuilder.RenameIndex(
                name: "IX_PROJECT_USER_IDUSER",
                table: "PROJECT_USER",
                newName: "IX_PROJECT_USER_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_PROJECT_USER_IDPROJECT",
                table: "PROJECT_USER",
                newName: "IX_PROJECT_USER_ID_PROJECT");

            migrationBuilder.RenameColumn(
                name: "IDUSER",
                table: "ProjectTeam",
                newName: "ID_USER");

            migrationBuilder.RenameColumn(
                name: "IDPROJECT",
                table: "ProjectTeam",
                newName: "ID_PROJECT");

            migrationBuilder.RenameColumn(
                name: "IDPROJECTTEAM",
                table: "ProjectTeam",
                newName: "ID_PROJECTTEAM");

            migrationBuilder.RenameColumn(
                name: "IDPROJECT",
                table: "Project",
                newName: "ID_PROJECT");

            migrationBuilder.RenameColumn(
                name: "IDPROFILE",
                table: "Profile",
                newName: "ID_PROFILE");

            migrationBuilder.RenameColumn(
                name: "IDUSER",
                table: "Notation",
                newName: "ID_USER");

            migrationBuilder.RenameColumn(
                name: "IDPROJECT",
                table: "Notation",
                newName: "ID_PROJECT");

            migrationBuilder.RenameColumn(
                name: "IDNOTATION",
                table: "Notation",
                newName: "ID_NOTATION");

            migrationBuilder.RenameColumn(
                name: "IDMOCKUP",
                table: "Mockup",
                newName: "ID_MOCKUP");

            migrationBuilder.RenameColumn(
                name: "IDKNOWLEDGE",
                table: "Knowledge",
                newName: "ID_KNOWLEDGE");

            migrationBuilder.RenameColumn(
                name: "IDUSER",
                table: "Impediment",
                newName: "ID_USER");

            migrationBuilder.RenameColumn(
                name: "IDIMPEDIMENT",
                table: "Impediment",
                newName: "ID_IMPEDIMENT");

            migrationBuilder.RenameColumn(
                name: "IDUSER",
                table: "ExecutionTask",
                newName: "ID_USER");

            migrationBuilder.RenameColumn(
                name: "IDSTATUS",
                table: "ExecutionTask",
                newName: "ID_STATUS");

            migrationBuilder.RenameColumn(
                name: "IDPROJECT",
                table: "ExecutionTask",
                newName: "ID_PROJECT");

            migrationBuilder.RenameColumn(
                name: "IDTASK",
                table: "ExecutionTask",
                newName: "ID_TASK");

            migrationBuilder.RenameColumn(
                name: "IDSTATUS",
                table: "Backlog",
                newName: "ID_STATUS");

            migrationBuilder.RenameColumn(
                name: "IDPROJECT",
                table: "Backlog",
                newName: "ID_PROJECT");

            migrationBuilder.RenameColumn(
                name: "IDMOCKUP",
                table: "Backlog",
                newName: "ID_MOCKUP");

            migrationBuilder.RenameColumn(
                name: "IDBACKLOG",
                table: "Backlog",
                newName: "ID_BACKLOG");

            migrationBuilder.RenameColumn(
                name: "IDATTACH",
                table: "AttachT",
                newName: "ID_ATTACH");

            migrationBuilder.RenameColumn(
                name: "IDADDRESS",
                table: "Address",
                newName: "ID_ADDRESS");

            migrationBuilder.AddColumn<int>(
                name: "StatusidStatus",
                table: "Backlog",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeam_ID_PROJECT",
                table: "ProjectTeam",
                column: "ID_PROJECT");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeam_ID_USER",
                table: "ProjectTeam",
                column: "ID_USER");

            migrationBuilder.CreateIndex(
                name: "IX_Notation_ID_PROJECT",
                table: "Notation",
                column: "ID_PROJECT");

            migrationBuilder.CreateIndex(
                name: "IX_Notation_ID_USER",
                table: "Notation",
                column: "ID_USER");

            migrationBuilder.CreateIndex(
                name: "IX_Impediment_ID_USER",
                table: "Impediment",
                column: "ID_USER");

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionTask_ID_PROJECT",
                table: "ExecutionTask",
                column: "ID_PROJECT");

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionTask_ID_STATUS",
                table: "ExecutionTask",
                column: "ID_STATUS");

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionTask_ID_USER",
                table: "ExecutionTask",
                column: "ID_USER");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_StatusidStatus",
                table: "Backlog",
                column: "StatusidStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_ID_MOCKUP",
                table: "Backlog",
                column: "ID_MOCKUP");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_ID_PROJECT",
                table: "Backlog",
                column: "ID_PROJECT");

            migrationBuilder.AddForeignKey(
                name: "FK_Backlog_Status_StatusidStatus",
                table: "Backlog",
                column: "StatusidStatus",
                principalTable: "Status",
                principalColumn: "ID_STATUS",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Backlog_Mockup_ID_MOCKUP",
                table: "Backlog",
                column: "ID_MOCKUP",
                principalTable: "Mockup",
                principalColumn: "ID_MOCKUP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Backlog_Project_ID_PROJECT",
                table: "Backlog",
                column: "ID_PROJECT",
                principalTable: "Project",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExecutionTask_Project_ID_PROJECT",
                table: "ExecutionTask",
                column: "ID_PROJECT",
                principalTable: "Project",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExecutionTask_Status_ID_STATUS",
                table: "ExecutionTask",
                column: "ID_STATUS",
                principalTable: "Status",
                principalColumn: "ID_STATUS",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExecutionTask_User_ID_USER",
                table: "ExecutionTask",
                column: "ID_USER",
                principalTable: "User",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Impediment_User_ID_USER",
                table: "Impediment",
                column: "ID_USER",
                principalTable: "User",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notation_Project_ID_PROJECT",
                table: "Notation",
                column: "ID_PROJECT",
                principalTable: "Project",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notation_User_ID_USER",
                table: "Notation",
                column: "ID_USER",
                principalTable: "User",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTeam_Project_ID_PROJECT",
                table: "ProjectTeam",
                column: "ID_PROJECT",
                principalTable: "Project",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTeam_User_ID_USER",
                table: "ProjectTeam",
                column: "ID_USER",
                principalTable: "User",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_USER_Project_ID_PROJECT",
                table: "PROJECT_USER",
                column: "ID_PROJECT",
                principalTable: "Project",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_USER_User_ID_USER",
                table: "PROJECT_USER",
                column: "ID_USER",
                principalTable: "User",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_ID_ADDRESS",
                table: "User",
                column: "ID_ADDRESS",
                principalTable: "Address",
                principalColumn: "ID_ADDRESS",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Profile_ID_PROFILE",
                table: "User",
                column: "ID_PROFILE",
                principalTable: "Profile",
                principalColumn: "ID_PROFILE",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backlog_Status_StatusidStatus",
                table: "Backlog");

            migrationBuilder.DropForeignKey(
                name: "FK_Backlog_Mockup_ID_MOCKUP",
                table: "Backlog");

            migrationBuilder.DropForeignKey(
                name: "FK_Backlog_Project_ID_PROJECT",
                table: "Backlog");

            migrationBuilder.DropForeignKey(
                name: "FK_ExecutionTask_Project_ID_PROJECT",
                table: "ExecutionTask");

            migrationBuilder.DropForeignKey(
                name: "FK_ExecutionTask_Status_ID_STATUS",
                table: "ExecutionTask");

            migrationBuilder.DropForeignKey(
                name: "FK_ExecutionTask_User_ID_USER",
                table: "ExecutionTask");

            migrationBuilder.DropForeignKey(
                name: "FK_Impediment_User_ID_USER",
                table: "Impediment");

            migrationBuilder.DropForeignKey(
                name: "FK_Notation_Project_ID_PROJECT",
                table: "Notation");

            migrationBuilder.DropForeignKey(
                name: "FK_Notation_User_ID_USER",
                table: "Notation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeam_Project_ID_PROJECT",
                table: "ProjectTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeam_User_ID_USER",
                table: "ProjectTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_Project_ID_PROJECT",
                table: "PROJECT_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_User_ID_USER",
                table: "PROJECT_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_ID_ADDRESS",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Profile_ID_PROFILE",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_ProjectTeam_ID_PROJECT",
                table: "ProjectTeam");

            migrationBuilder.DropIndex(
                name: "IX_ProjectTeam_ID_USER",
                table: "ProjectTeam");

            migrationBuilder.DropIndex(
                name: "IX_Notation_ID_PROJECT",
                table: "Notation");

            migrationBuilder.DropIndex(
                name: "IX_Notation_ID_USER",
                table: "Notation");

            migrationBuilder.DropIndex(
                name: "IX_Impediment_ID_USER",
                table: "Impediment");

            migrationBuilder.DropIndex(
                name: "IX_ExecutionTask_ID_PROJECT",
                table: "ExecutionTask");

            migrationBuilder.DropIndex(
                name: "IX_ExecutionTask_ID_STATUS",
                table: "ExecutionTask");

            migrationBuilder.DropIndex(
                name: "IX_ExecutionTask_ID_USER",
                table: "ExecutionTask");

            migrationBuilder.DropIndex(
                name: "IX_Backlog_StatusidStatus",
                table: "Backlog");

            migrationBuilder.DropIndex(
                name: "IX_Backlog_ID_MOCKUP",
                table: "Backlog");

            migrationBuilder.DropIndex(
                name: "IX_Backlog_ID_PROJECT",
                table: "Backlog");

            migrationBuilder.DropColumn(
                name: "StatusidStatus",
                table: "Backlog");

            migrationBuilder.RenameColumn(
                name: "ID_PROFILE",
                table: "User",
                newName: "IDPROFILE");

            migrationBuilder.RenameColumn(
                name: "ID_ADDRESS",
                table: "User",
                newName: "IDADDRESS");

            migrationBuilder.RenameColumn(
                name: "ID_USER",
                table: "User",
                newName: "IDUSER");

            migrationBuilder.RenameIndex(
                name: "IX_User_ID_PROFILE",
                table: "User",
                newName: "IX_User_IDPROFILE");

            migrationBuilder.RenameIndex(
                name: "IX_User_ID_ADDRESS",
                table: "User",
                newName: "IX_User_IDADDRESS");

            migrationBuilder.RenameColumn(
                name: "ID_TEAM",
                table: "Team",
                newName: "IDTEAM");

            migrationBuilder.RenameColumn(
                name: "ID_STATUS",
                table: "Status",
                newName: "IDSTATUS");

            migrationBuilder.RenameColumn(
                name: "ID_USER",
                table: "PROJECT_USER",
                newName: "IDUSER");

            migrationBuilder.RenameColumn(
                name: "ID_PROJECT",
                table: "PROJECT_USER",
                newName: "IDPROJECT");

            migrationBuilder.RenameColumn(
                name: "ID_PROJECT_USER",
                table: "PROJECT_USER",
                newName: "IDPROJECT_USER");

            migrationBuilder.RenameIndex(
                name: "IX_PROJECT_USER_ID_USER",
                table: "PROJECT_USER",
                newName: "IX_PROJECT_USER_IDUSER");

            migrationBuilder.RenameIndex(
                name: "IX_PROJECT_USER_ID_PROJECT",
                table: "PROJECT_USER",
                newName: "IX_PROJECT_USER_IDPROJECT");

            migrationBuilder.RenameColumn(
                name: "ID_USER",
                table: "ProjectTeam",
                newName: "IDUSER");

            migrationBuilder.RenameColumn(
                name: "ID_PROJECT",
                table: "ProjectTeam",
                newName: "IDPROJECT");

            migrationBuilder.RenameColumn(
                name: "ID_PROJECTTEAM",
                table: "ProjectTeam",
                newName: "IDPROJECTTEAM");

            migrationBuilder.RenameColumn(
                name: "ID_PROJECT",
                table: "Project",
                newName: "IDPROJECT");

            migrationBuilder.RenameColumn(
                name: "ID_PROFILE",
                table: "Profile",
                newName: "IDPROFILE");

            migrationBuilder.RenameColumn(
                name: "ID_USER",
                table: "Notation",
                newName: "IDUSER");

            migrationBuilder.RenameColumn(
                name: "ID_PROJECT",
                table: "Notation",
                newName: "IDPROJECT");

            migrationBuilder.RenameColumn(
                name: "ID_NOTATION",
                table: "Notation",
                newName: "IDNOTATION");

            migrationBuilder.RenameColumn(
                name: "ID_MOCKUP",
                table: "Mockup",
                newName: "IDMOCKUP");

            migrationBuilder.RenameColumn(
                name: "ID_KNOWLEDGE",
                table: "Knowledge",
                newName: "IDKNOWLEDGE");

            migrationBuilder.RenameColumn(
                name: "ID_USER",
                table: "Impediment",
                newName: "IDUSER");

            migrationBuilder.RenameColumn(
                name: "ID_IMPEDIMENT",
                table: "Impediment",
                newName: "IDIMPEDIMENT");

            migrationBuilder.RenameColumn(
                name: "ID_USER",
                table: "ExecutionTask",
                newName: "IDUSER");

            migrationBuilder.RenameColumn(
                name: "ID_STATUS",
                table: "ExecutionTask",
                newName: "IDSTATUS");

            migrationBuilder.RenameColumn(
                name: "ID_PROJECT",
                table: "ExecutionTask",
                newName: "IDPROJECT");

            migrationBuilder.RenameColumn(
                name: "ID_TASK",
                table: "ExecutionTask",
                newName: "IDTASK");

            migrationBuilder.RenameColumn(
                name: "ID_STATUS",
                table: "Backlog",
                newName: "IDSTATUS");

            migrationBuilder.RenameColumn(
                name: "ID_PROJECT",
                table: "Backlog",
                newName: "IDPROJECT");

            migrationBuilder.RenameColumn(
                name: "ID_MOCKUP",
                table: "Backlog",
                newName: "IDMOCKUP");

            migrationBuilder.RenameColumn(
                name: "ID_BACKLOG",
                table: "Backlog",
                newName: "IDBACKLOG");

            migrationBuilder.RenameColumn(
                name: "ID_ATTACH",
                table: "AttachT",
                newName: "IDATTACH");

            migrationBuilder.RenameColumn(
                name: "ID_ADDRESS",
                table: "Address",
                newName: "IDADDRESS");

            migrationBuilder.AddColumn<int>(
                name: "ProjectidProject",
                table: "ExecutionTask",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionTask_ProjectidProject",
                table: "ExecutionTask",
                column: "ProjectidProject");

            migrationBuilder.AddForeignKey(
                name: "FK_ExecutionTask_Project_ProjectidProject",
                table: "ExecutionTask",
                column: "ProjectidProject",
                principalTable: "Project",
                principalColumn: "IDPROJECT",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_IDADDRESS",
                table: "User",
                column: "IDADDRESS",
                principalTable: "Address",
                principalColumn: "IDADDRESS",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Profile_IDPROFILE",
                table: "User",
                column: "IDPROFILE",
                principalTable: "Profile",
                principalColumn: "IDPROFILE",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
