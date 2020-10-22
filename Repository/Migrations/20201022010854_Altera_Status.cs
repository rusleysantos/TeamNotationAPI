using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Altera_Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttachT_Task_TaskidTask",
                table: "AttachT");

            migrationBuilder.DropForeignKey(
                name: "FK_Backlog_StatusBacklog_StatusidStatusBacklog",
                table: "Backlog");

            migrationBuilder.DropForeignKey(
                name: "FK_Backlog_Task_TaskidTask",
                table: "Backlog");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_StatusTask_StatusidStatus",
                table: "Task");

            migrationBuilder.DropTable(
                name: "StatusBacklog");

            migrationBuilder.DropTable(
                name: "StatusTask");

            migrationBuilder.DropIndex(
                name: "IX_Backlog_StatusidStatusBacklog",
                table: "Backlog");

            migrationBuilder.DropIndex(
                name: "IX_Backlog_TaskidTask",
                table: "Backlog");

            migrationBuilder.DropIndex(
                name: "IX_AttachT_TaskidTask",
                table: "AttachT");

            migrationBuilder.DropColumn(
                name: "StatusidStatusBacklog",
                table: "Backlog");

            migrationBuilder.DropColumn(
                name: "TaskidTask",
                table: "Backlog");

            migrationBuilder.DropColumn(
                name: "TaskidTask",
                table: "AttachT");

            migrationBuilder.AddColumn<int>(
                name: "ExecutionTaskidTask",
                table: "Backlog",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusidStatus",
                table: "Backlog",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExecutionTaskidTask",
                table: "AttachT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    idStatus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.idStatus);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_ExecutionTaskidTask",
                table: "Backlog",
                column: "ExecutionTaskidTask");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_StatusidStatus",
                table: "Backlog",
                column: "StatusidStatus");

            migrationBuilder.CreateIndex(
                name: "IX_AttachT_ExecutionTaskidTask",
                table: "AttachT",
                column: "ExecutionTaskidTask");

            migrationBuilder.AddForeignKey(
                name: "FK_AttachT_Task_ExecutionTaskidTask",
                table: "AttachT",
                column: "ExecutionTaskidTask",
                principalTable: "Task",
                principalColumn: "idTask",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Backlog_Task_ExecutionTaskidTask",
                table: "Backlog",
                column: "ExecutionTaskidTask",
                principalTable: "Task",
                principalColumn: "idTask",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Backlog_Status_StatusidStatus",
                table: "Backlog",
                column: "StatusidStatus",
                principalTable: "Status",
                principalColumn: "idStatus",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Status_StatusidStatus",
                table: "Task",
                column: "StatusidStatus",
                principalTable: "Status",
                principalColumn: "idStatus",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttachT_Task_ExecutionTaskidTask",
                table: "AttachT");

            migrationBuilder.DropForeignKey(
                name: "FK_Backlog_Task_ExecutionTaskidTask",
                table: "Backlog");

            migrationBuilder.DropForeignKey(
                name: "FK_Backlog_Status_StatusidStatus",
                table: "Backlog");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Status_StatusidStatus",
                table: "Task");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Backlog_ExecutionTaskidTask",
                table: "Backlog");

            migrationBuilder.DropIndex(
                name: "IX_Backlog_StatusidStatus",
                table: "Backlog");

            migrationBuilder.DropIndex(
                name: "IX_AttachT_ExecutionTaskidTask",
                table: "AttachT");

            migrationBuilder.DropColumn(
                name: "ExecutionTaskidTask",
                table: "Backlog");

            migrationBuilder.DropColumn(
                name: "StatusidStatus",
                table: "Backlog");

            migrationBuilder.DropColumn(
                name: "ExecutionTaskidTask",
                table: "AttachT");

            migrationBuilder.AddColumn<int>(
                name: "StatusidStatusBacklog",
                table: "Backlog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskidTask",
                table: "Backlog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskidTask",
                table: "AttachT",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StatusBacklog",
                columns: table => new
                {
                    idStatusBacklog = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusBacklog", x => x.idStatusBacklog);
                });

            migrationBuilder.CreateTable(
                name: "StatusTask",
                columns: table => new
                {
                    idStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTask", x => x.idStatus);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_StatusidStatusBacklog",
                table: "Backlog",
                column: "StatusidStatusBacklog");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_TaskidTask",
                table: "Backlog",
                column: "TaskidTask");

            migrationBuilder.CreateIndex(
                name: "IX_AttachT_TaskidTask",
                table: "AttachT",
                column: "TaskidTask");

            migrationBuilder.AddForeignKey(
                name: "FK_AttachT_Task_TaskidTask",
                table: "AttachT",
                column: "TaskidTask",
                principalTable: "Task",
                principalColumn: "idTask",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Backlog_StatusBacklog_StatusidStatusBacklog",
                table: "Backlog",
                column: "StatusidStatusBacklog",
                principalTable: "StatusBacklog",
                principalColumn: "idStatusBacklog",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Backlog_Task_TaskidTask",
                table: "Backlog",
                column: "TaskidTask",
                principalTable: "Task",
                principalColumn: "idTask",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_StatusTask_StatusidStatus",
                table: "Task",
                column: "StatusidStatus",
                principalTable: "StatusTask",
                principalColumn: "idStatus",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
