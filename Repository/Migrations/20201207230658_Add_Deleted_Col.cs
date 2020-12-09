using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Add_Deleted_Col : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO STATUS
                                    (DESCRIPTION, TIPO) 
                                   VALUES
                                    ('Em Andamento','TA'),
                                    ('Impedida','TA'),
                                    ('Concluída','TA'),
                                    ('Bloqueada','TA')");

            migrationBuilder.DropForeignKey(
                name: "FK_AttachT_ExecutionTask_ExecutionTaskidTask",
                table: "AttachT");

            migrationBuilder.DropForeignKey(
                name: "FK_AttachT_Impediment_ImpedimentidImpediment",
                table: "AttachT");

            migrationBuilder.DropForeignKey(
                name: "FK_AttachT_Knowledge_KnowledgeidKnowledge",
                table: "AttachT");

            migrationBuilder.DropForeignKey(
                name: "FK_AttachT_Notation_NotationidNotation",
                table: "AttachT");

            migrationBuilder.DropForeignKey(
                name: "FK_Backlog_ExecutionTask_ExecutionTaskidTask",
                table: "Backlog");

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
                name: "FK_ExecutionTask_Impediment_ImpedimentidImpediment",
                table: "ExecutionTask");

            migrationBuilder.DropForeignKey(
                name: "FK_ExecutionTask_Knowledge_KnowledgeidKnowledge",
                table: "ExecutionTask");

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
                name: "FK_PROJECT_USER_Project_ID_PROJECT",
                table: "PROJECT_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_User_ID_USER",
                table: "PROJECT_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeam_Project_ID_PROJECT",
                table: "ProjectTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeam_User_ID_USER",
                table: "ProjectTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_ID_ADDRESS",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Profile_ID_PROFILE",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notation",
                table: "Notation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mockup",
                table: "Mockup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Knowledge",
                table: "Knowledge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Impediment",
                table: "Impediment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backlog",
                table: "Backlog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectTeam",
                table: "ProjectTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExecutionTask",
                table: "ExecutionTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttachT",
                table: "AttachT");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "USER");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "TEAM");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "STATUS");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "PROJECT");

            migrationBuilder.RenameTable(
                name: "Profile",
                newName: "PROFILE");

            migrationBuilder.RenameTable(
                name: "Notation",
                newName: "NOTATION");

            migrationBuilder.RenameTable(
                name: "Mockup",
                newName: "MOCKUP");

            migrationBuilder.RenameTable(
                name: "Knowledge",
                newName: "KNOWLEDGE");

            migrationBuilder.RenameTable(
                name: "Impediment",
                newName: "IMPEDIMENT");

            migrationBuilder.RenameTable(
                name: "Backlog",
                newName: "BACKLOG");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "ADDRESS");

            migrationBuilder.RenameTable(
                name: "ProjectTeam",
                newName: "PROJECT_TEAM");

            migrationBuilder.RenameTable(
                name: "ExecutionTask",
                newName: "EXECUTION_TASK");

            migrationBuilder.RenameTable(
                name: "AttachT",
                newName: "ATTACH_T");

            migrationBuilder.RenameIndex(
                name: "IX_User_ID_PROFILE",
                table: "USER",
                newName: "IX_USER_ID_PROFILE");

            migrationBuilder.RenameIndex(
                name: "IX_User_ID_ADDRESS",
                table: "USER",
                newName: "IX_USER_ID_ADDRESS");

            migrationBuilder.RenameIndex(
                name: "IX_Notation_ID_USER",
                table: "NOTATION",
                newName: "IX_NOTATION_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_Notation_ID_PROJECT",
                table: "NOTATION",
                newName: "IX_NOTATION_ID_PROJECT");

            migrationBuilder.RenameIndex(
                name: "IX_Impediment_ID_USER",
                table: "IMPEDIMENT",
                newName: "IX_IMPEDIMENT_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_Backlog_ID_PROJECT",
                table: "BACKLOG",
                newName: "IX_BACKLOG_ID_PROJECT");

            migrationBuilder.RenameIndex(
                name: "IX_Backlog_ID_MOCKUP",
                table: "BACKLOG",
                newName: "IX_BACKLOG_ID_MOCKUP");

            migrationBuilder.RenameIndex(
                name: "IX_Backlog_StatusidStatus",
                table: "BACKLOG",
                newName: "IX_BACKLOG_StatusidStatus");

            migrationBuilder.RenameIndex(
                name: "IX_Backlog_ExecutionTaskidTask",
                table: "BACKLOG",
                newName: "IX_BACKLOG_ExecutionTaskidTask");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTeam_ID_USER",
                table: "PROJECT_TEAM",
                newName: "IX_PROJECT_TEAM_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTeam_ID_PROJECT",
                table: "PROJECT_TEAM",
                newName: "IX_PROJECT_TEAM_ID_PROJECT");

            migrationBuilder.RenameIndex(
                name: "IX_ExecutionTask_ID_USER",
                table: "EXECUTION_TASK",
                newName: "IX_EXECUTION_TASK_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_ExecutionTask_ID_STATUS",
                table: "EXECUTION_TASK",
                newName: "IX_EXECUTION_TASK_ID_STATUS");

            migrationBuilder.RenameIndex(
                name: "IX_ExecutionTask_ID_PROJECT",
                table: "EXECUTION_TASK",
                newName: "IX_EXECUTION_TASK_ID_PROJECT");

            migrationBuilder.RenameIndex(
                name: "IX_ExecutionTask_KnowledgeidKnowledge",
                table: "EXECUTION_TASK",
                newName: "IX_EXECUTION_TASK_KnowledgeidKnowledge");

            migrationBuilder.RenameIndex(
                name: "IX_ExecutionTask_ImpedimentidImpediment",
                table: "EXECUTION_TASK",
                newName: "IX_EXECUTION_TASK_ImpedimentidImpediment");

            migrationBuilder.RenameIndex(
                name: "IX_AttachT_NotationidNotation",
                table: "ATTACH_T",
                newName: "IX_ATTACH_T_NotationidNotation");

            migrationBuilder.RenameIndex(
                name: "IX_AttachT_KnowledgeidKnowledge",
                table: "ATTACH_T",
                newName: "IX_ATTACH_T_KnowledgeidKnowledge");

            migrationBuilder.RenameIndex(
                name: "IX_AttachT_ImpedimentidImpediment",
                table: "ATTACH_T",
                newName: "IX_ATTACH_T_ImpedimentidImpediment");

            migrationBuilder.RenameIndex(
                name: "IX_AttachT_ExecutionTaskidTask",
                table: "ATTACH_T",
                newName: "IX_ATTACH_T_ExecutionTaskidTask");

            migrationBuilder.AddColumn<bool>(
                name: "DELETED",
                table: "NOTATION",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DELETED",
                table: "EXECUTION_TASK",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_USER",
                table: "USER",
                column: "ID_USER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TEAM",
                table: "TEAM",
                column: "ID_TEAM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_STATUS",
                table: "STATUS",
                column: "ID_STATUS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PROJECT",
                table: "PROJECT",
                column: "ID_PROJECT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PROFILE",
                table: "PROFILE",
                column: "ID_PROFILE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NOTATION",
                table: "NOTATION",
                column: "ID_NOTATION");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MOCKUP",
                table: "MOCKUP",
                column: "ID_MOCKUP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KNOWLEDGE",
                table: "KNOWLEDGE",
                column: "ID_KNOWLEDGE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IMPEDIMENT",
                table: "IMPEDIMENT",
                column: "ID_IMPEDIMENT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BACKLOG",
                table: "BACKLOG",
                column: "ID_BACKLOG");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ADDRESS",
                table: "ADDRESS",
                column: "ID_ADDRESS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PROJECT_TEAM",
                table: "PROJECT_TEAM",
                column: "ID_PROJECTTEAM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EXECUTION_TASK",
                table: "EXECUTION_TASK",
                column: "ID_TASK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ATTACH_T",
                table: "ATTACH_T",
                column: "ID_ATTACH");

            migrationBuilder.AddForeignKey(
                name: "FK_ATTACH_T_EXECUTION_TASK_ExecutionTaskidTask",
                table: "ATTACH_T",
                column: "ExecutionTaskidTask",
                principalTable: "EXECUTION_TASK",
                principalColumn: "ID_TASK",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ATTACH_T_IMPEDIMENT_ImpedimentidImpediment",
                table: "ATTACH_T",
                column: "ImpedimentidImpediment",
                principalTable: "IMPEDIMENT",
                principalColumn: "ID_IMPEDIMENT",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ATTACH_T_KNOWLEDGE_KnowledgeidKnowledge",
                table: "ATTACH_T",
                column: "KnowledgeidKnowledge",
                principalTable: "KNOWLEDGE",
                principalColumn: "ID_KNOWLEDGE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ATTACH_T_NOTATION_NotationidNotation",
                table: "ATTACH_T",
                column: "NotationidNotation",
                principalTable: "NOTATION",
                principalColumn: "ID_NOTATION",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BACKLOG_EXECUTION_TASK_ExecutionTaskidTask",
                table: "BACKLOG",
                column: "ExecutionTaskidTask",
                principalTable: "EXECUTION_TASK",
                principalColumn: "ID_TASK",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BACKLOG_STATUS_StatusidStatus",
                table: "BACKLOG",
                column: "StatusidStatus",
                principalTable: "STATUS",
                principalColumn: "ID_STATUS",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BACKLOG_MOCKUP_ID_MOCKUP",
                table: "BACKLOG",
                column: "ID_MOCKUP",
                principalTable: "MOCKUP",
                principalColumn: "ID_MOCKUP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BACKLOG_PROJECT_ID_PROJECT",
                table: "BACKLOG",
                column: "ID_PROJECT",
                principalTable: "PROJECT",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EXECUTION_TASK_IMPEDIMENT_ImpedimentidImpediment",
                table: "EXECUTION_TASK",
                column: "ImpedimentidImpediment",
                principalTable: "IMPEDIMENT",
                principalColumn: "ID_IMPEDIMENT",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EXECUTION_TASK_KNOWLEDGE_KnowledgeidKnowledge",
                table: "EXECUTION_TASK",
                column: "KnowledgeidKnowledge",
                principalTable: "KNOWLEDGE",
                principalColumn: "ID_KNOWLEDGE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EXECUTION_TASK_PROJECT_ID_PROJECT",
                table: "EXECUTION_TASK",
                column: "ID_PROJECT",
                principalTable: "PROJECT",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EXECUTION_TASK_STATUS_ID_STATUS",
                table: "EXECUTION_TASK",
                column: "ID_STATUS",
                principalTable: "STATUS",
                principalColumn: "ID_STATUS",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EXECUTION_TASK_USER_ID_USER",
                table: "EXECUTION_TASK",
                column: "ID_USER",
                principalTable: "USER",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IMPEDIMENT_USER_ID_USER",
                table: "IMPEDIMENT",
                column: "ID_USER",
                principalTable: "USER",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTATION_PROJECT_ID_PROJECT",
                table: "NOTATION",
                column: "ID_PROJECT",
                principalTable: "PROJECT",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTATION_USER_ID_USER",
                table: "NOTATION",
                column: "ID_USER",
                principalTable: "USER",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_TEAM_PROJECT_ID_PROJECT",
                table: "PROJECT_TEAM",
                column: "ID_PROJECT",
                principalTable: "PROJECT",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_TEAM_USER_ID_USER",
                table: "PROJECT_TEAM",
                column: "ID_USER",
                principalTable: "USER",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_USER_PROJECT_ID_PROJECT",
                table: "PROJECT_USER",
                column: "ID_PROJECT",
                principalTable: "PROJECT",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_USER_USER_ID_USER",
                table: "PROJECT_USER",
                column: "ID_USER",
                principalTable: "USER",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_ADDRESS_ID_ADDRESS",
                table: "USER",
                column: "ID_ADDRESS",
                principalTable: "ADDRESS",
                principalColumn: "ID_ADDRESS",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_PROFILE_ID_PROFILE",
                table: "USER",
                column: "ID_PROFILE",
                principalTable: "PROFILE",
                principalColumn: "ID_PROFILE",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ATTACH_T_EXECUTION_TASK_ExecutionTaskidTask",
                table: "ATTACH_T");

            migrationBuilder.DropForeignKey(
                name: "FK_ATTACH_T_IMPEDIMENT_ImpedimentidImpediment",
                table: "ATTACH_T");

            migrationBuilder.DropForeignKey(
                name: "FK_ATTACH_T_KNOWLEDGE_KnowledgeidKnowledge",
                table: "ATTACH_T");

            migrationBuilder.DropForeignKey(
                name: "FK_ATTACH_T_NOTATION_NotationidNotation",
                table: "ATTACH_T");

            migrationBuilder.DropForeignKey(
                name: "FK_BACKLOG_EXECUTION_TASK_ExecutionTaskidTask",
                table: "BACKLOG");

            migrationBuilder.DropForeignKey(
                name: "FK_BACKLOG_STATUS_StatusidStatus",
                table: "BACKLOG");

            migrationBuilder.DropForeignKey(
                name: "FK_BACKLOG_MOCKUP_ID_MOCKUP",
                table: "BACKLOG");

            migrationBuilder.DropForeignKey(
                name: "FK_BACKLOG_PROJECT_ID_PROJECT",
                table: "BACKLOG");

            migrationBuilder.DropForeignKey(
                name: "FK_EXECUTION_TASK_IMPEDIMENT_ImpedimentidImpediment",
                table: "EXECUTION_TASK");

            migrationBuilder.DropForeignKey(
                name: "FK_EXECUTION_TASK_KNOWLEDGE_KnowledgeidKnowledge",
                table: "EXECUTION_TASK");

            migrationBuilder.DropForeignKey(
                name: "FK_EXECUTION_TASK_PROJECT_ID_PROJECT",
                table: "EXECUTION_TASK");

            migrationBuilder.DropForeignKey(
                name: "FK_EXECUTION_TASK_STATUS_ID_STATUS",
                table: "EXECUTION_TASK");

            migrationBuilder.DropForeignKey(
                name: "FK_EXECUTION_TASK_USER_ID_USER",
                table: "EXECUTION_TASK");

            migrationBuilder.DropForeignKey(
                name: "FK_IMPEDIMENT_USER_ID_USER",
                table: "IMPEDIMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTATION_PROJECT_ID_PROJECT",
                table: "NOTATION");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTATION_USER_ID_USER",
                table: "NOTATION");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_TEAM_PROJECT_ID_PROJECT",
                table: "PROJECT_TEAM");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_TEAM_USER_ID_USER",
                table: "PROJECT_TEAM");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_PROJECT_ID_PROJECT",
                table: "PROJECT_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_USER_USER_ID_USER",
                table: "PROJECT_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_ADDRESS_ID_ADDRESS",
                table: "USER");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_PROFILE_ID_PROFILE",
                table: "USER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USER",
                table: "USER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TEAM",
                table: "TEAM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_STATUS",
                table: "STATUS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PROJECT",
                table: "PROJECT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PROFILE",
                table: "PROFILE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NOTATION",
                table: "NOTATION");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MOCKUP",
                table: "MOCKUP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KNOWLEDGE",
                table: "KNOWLEDGE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IMPEDIMENT",
                table: "IMPEDIMENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BACKLOG",
                table: "BACKLOG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ADDRESS",
                table: "ADDRESS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PROJECT_TEAM",
                table: "PROJECT_TEAM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EXECUTION_TASK",
                table: "EXECUTION_TASK");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ATTACH_T",
                table: "ATTACH_T");

            migrationBuilder.DropColumn(
                name: "DELETED",
                table: "NOTATION");

            migrationBuilder.DropColumn(
                name: "DELETED",
                table: "EXECUTION_TASK");

            migrationBuilder.RenameTable(
                name: "USER",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "TEAM",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "STATUS",
                newName: "Status");

            migrationBuilder.RenameTable(
                name: "PROJECT",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "PROFILE",
                newName: "Profile");

            migrationBuilder.RenameTable(
                name: "NOTATION",
                newName: "Notation");

            migrationBuilder.RenameTable(
                name: "MOCKUP",
                newName: "Mockup");

            migrationBuilder.RenameTable(
                name: "KNOWLEDGE",
                newName: "Knowledge");

            migrationBuilder.RenameTable(
                name: "IMPEDIMENT",
                newName: "Impediment");

            migrationBuilder.RenameTable(
                name: "BACKLOG",
                newName: "Backlog");

            migrationBuilder.RenameTable(
                name: "ADDRESS",
                newName: "Address");

            migrationBuilder.RenameTable(
                name: "PROJECT_TEAM",
                newName: "ProjectTeam");

            migrationBuilder.RenameTable(
                name: "EXECUTION_TASK",
                newName: "ExecutionTask");

            migrationBuilder.RenameTable(
                name: "ATTACH_T",
                newName: "AttachT");

            migrationBuilder.RenameIndex(
                name: "IX_USER_ID_PROFILE",
                table: "User",
                newName: "IX_User_ID_PROFILE");

            migrationBuilder.RenameIndex(
                name: "IX_USER_ID_ADDRESS",
                table: "User",
                newName: "IX_User_ID_ADDRESS");

            migrationBuilder.RenameIndex(
                name: "IX_NOTATION_ID_USER",
                table: "Notation",
                newName: "IX_Notation_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_NOTATION_ID_PROJECT",
                table: "Notation",
                newName: "IX_Notation_ID_PROJECT");

            migrationBuilder.RenameIndex(
                name: "IX_IMPEDIMENT_ID_USER",
                table: "Impediment",
                newName: "IX_Impediment_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_BACKLOG_ID_PROJECT",
                table: "Backlog",
                newName: "IX_Backlog_ID_PROJECT");

            migrationBuilder.RenameIndex(
                name: "IX_BACKLOG_ID_MOCKUP",
                table: "Backlog",
                newName: "IX_Backlog_ID_MOCKUP");

            migrationBuilder.RenameIndex(
                name: "IX_BACKLOG_StatusidStatus",
                table: "Backlog",
                newName: "IX_Backlog_StatusidStatus");

            migrationBuilder.RenameIndex(
                name: "IX_BACKLOG_ExecutionTaskidTask",
                table: "Backlog",
                newName: "IX_Backlog_ExecutionTaskidTask");

            migrationBuilder.RenameIndex(
                name: "IX_PROJECT_TEAM_ID_USER",
                table: "ProjectTeam",
                newName: "IX_ProjectTeam_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_PROJECT_TEAM_ID_PROJECT",
                table: "ProjectTeam",
                newName: "IX_ProjectTeam_ID_PROJECT");

            migrationBuilder.RenameIndex(
                name: "IX_EXECUTION_TASK_ID_USER",
                table: "ExecutionTask",
                newName: "IX_ExecutionTask_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_EXECUTION_TASK_ID_STATUS",
                table: "ExecutionTask",
                newName: "IX_ExecutionTask_ID_STATUS");

            migrationBuilder.RenameIndex(
                name: "IX_EXECUTION_TASK_ID_PROJECT",
                table: "ExecutionTask",
                newName: "IX_ExecutionTask_ID_PROJECT");

            migrationBuilder.RenameIndex(
                name: "IX_EXECUTION_TASK_KnowledgeidKnowledge",
                table: "ExecutionTask",
                newName: "IX_ExecutionTask_KnowledgeidKnowledge");

            migrationBuilder.RenameIndex(
                name: "IX_EXECUTION_TASK_ImpedimentidImpediment",
                table: "ExecutionTask",
                newName: "IX_ExecutionTask_ImpedimentidImpediment");

            migrationBuilder.RenameIndex(
                name: "IX_ATTACH_T_NotationidNotation",
                table: "AttachT",
                newName: "IX_AttachT_NotationidNotation");

            migrationBuilder.RenameIndex(
                name: "IX_ATTACH_T_KnowledgeidKnowledge",
                table: "AttachT",
                newName: "IX_AttachT_KnowledgeidKnowledge");

            migrationBuilder.RenameIndex(
                name: "IX_ATTACH_T_ImpedimentidImpediment",
                table: "AttachT",
                newName: "IX_AttachT_ImpedimentidImpediment");

            migrationBuilder.RenameIndex(
                name: "IX_ATTACH_T_ExecutionTaskidTask",
                table: "AttachT",
                newName: "IX_AttachT_ExecutionTaskidTask");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "ID_USER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "ID_TEAM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "ID_STATUS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ID_PROJECT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                column: "ID_PROFILE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notation",
                table: "Notation",
                column: "ID_NOTATION");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mockup",
                table: "Mockup",
                column: "ID_MOCKUP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Knowledge",
                table: "Knowledge",
                column: "ID_KNOWLEDGE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Impediment",
                table: "Impediment",
                column: "ID_IMPEDIMENT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backlog",
                table: "Backlog",
                column: "ID_BACKLOG");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "ID_ADDRESS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectTeam",
                table: "ProjectTeam",
                column: "ID_PROJECTTEAM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExecutionTask",
                table: "ExecutionTask",
                column: "ID_TASK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttachT",
                table: "AttachT",
                column: "ID_ATTACH");

            migrationBuilder.AddForeignKey(
                name: "FK_AttachT_ExecutionTask_ExecutionTaskidTask",
                table: "AttachT",
                column: "ExecutionTaskidTask",
                principalTable: "ExecutionTask",
                principalColumn: "ID_TASK",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttachT_Impediment_ImpedimentidImpediment",
                table: "AttachT",
                column: "ImpedimentidImpediment",
                principalTable: "Impediment",
                principalColumn: "ID_IMPEDIMENT",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttachT_Knowledge_KnowledgeidKnowledge",
                table: "AttachT",
                column: "KnowledgeidKnowledge",
                principalTable: "Knowledge",
                principalColumn: "ID_KNOWLEDGE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttachT_Notation_NotationidNotation",
                table: "AttachT",
                column: "NotationidNotation",
                principalTable: "Notation",
                principalColumn: "ID_NOTATION",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Backlog_ExecutionTask_ExecutionTaskidTask",
                table: "Backlog",
                column: "ExecutionTaskidTask",
                principalTable: "ExecutionTask",
                principalColumn: "ID_TASK",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_ExecutionTask_Impediment_ImpedimentidImpediment",
                table: "ExecutionTask",
                column: "ImpedimentidImpediment",
                principalTable: "Impediment",
                principalColumn: "ID_IMPEDIMENT",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExecutionTask_Knowledge_KnowledgeidKnowledge",
                table: "ExecutionTask",
                column: "KnowledgeidKnowledge",
                principalTable: "Knowledge",
                principalColumn: "ID_KNOWLEDGE",
                onDelete: ReferentialAction.Restrict);

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
    }
}
