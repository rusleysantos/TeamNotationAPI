using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Migration_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    IDADDRESS = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NUMBER = table.Column<int>(nullable: false),
                    STREET = table.Column<string>(nullable: true),
                    COUNTRIE = table.Column<string>(nullable: true),
                    LATITUDE = table.Column<string>(nullable: true),
                    LONGITUDE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.IDADDRESS);
                });

            migrationBuilder.CreateTable(
                name: "Impediment",
                columns: table => new
                {
                    IDIMPEDIMENT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    IDUSER = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impediment", x => x.IDIMPEDIMENT);
                });

            migrationBuilder.CreateTable(
                name: "Knowledge",
                columns: table => new
                {
                    IDKNOWLEDGE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledge", x => x.IDKNOWLEDGE);
                });

            migrationBuilder.CreateTable(
                name: "Mockup",
                columns: table => new
                {
                    IDMOCKUP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE = table.Column<string>(nullable: true),
                    BLOB = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mockup", x => x.IDMOCKUP);
                });

            migrationBuilder.CreateTable(
                name: "Notation",
                columns: table => new
                {
                    IDNOTATION = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    POSITIONCARD = table.Column<string>(nullable: true),
                    IDUSER = table.Column<int>(nullable: false),
                    IDPROJECT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notation", x => x.IDNOTATION);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    IDPROFILE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(nullable: true),
                    SURNAME = table.Column<string>(nullable: true),
                    BIRTHDATE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.IDPROFILE);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    IDPROJECT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    PERCENTDONE = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.IDPROJECT);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTeam",
                columns: table => new
                {
                    IDPROJECTTEAM = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDUSER = table.Column<int>(nullable: false),
                    IDPROJECT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTeam", x => x.IDPROJECTTEAM);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    IDSTATUS = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    TIPO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.IDSTATUS);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    IDTEAM = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.IDTEAM);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IDUSER = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGIN = table.Column<string>(nullable: true),
                    PASSWORD = table.Column<string>(nullable: true),
                    IDADDRESS = table.Column<int>(nullable: false),
                    IDPROFILE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IDUSER);
                });

            migrationBuilder.CreateTable(
                name: "ExecutionTask",
                columns: table => new
                {
                    IDTASK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    WEIGHT = table.Column<string>(nullable: true),
                    EFFORT = table.Column<string>(nullable: true),
                    IDSTATUS = table.Column<int>(nullable: false),
                    IDUSER = table.Column<int>(nullable: false),
                    IDPROJECT = table.Column<int>(nullable: false),
                    ImpedimentidImpediment = table.Column<int>(nullable: true),
                    KnowledgeidKnowledge = table.Column<int>(nullable: true),
                    ProjectidProject = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExecutionTask", x => x.IDTASK);
                    table.ForeignKey(
                        name: "FK_ExecutionTask_Impediment_ImpedimentidImpediment",
                        column: x => x.ImpedimentidImpediment,
                        principalTable: "Impediment",
                        principalColumn: "IDIMPEDIMENT",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExecutionTask_Knowledge_KnowledgeidKnowledge",
                        column: x => x.KnowledgeidKnowledge,
                        principalTable: "Knowledge",
                        principalColumn: "IDKNOWLEDGE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExecutionTask_Project_ProjectidProject",
                        column: x => x.ProjectidProject,
                        principalTable: "Project",
                        principalColumn: "IDPROJECT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    IDPROJECTUSER = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectidProject = table.Column<int>(nullable: true),
                    IDUSER = table.Column<int>(nullable: false),
                    IDPROJECT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => x.IDPROJECTUSER);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Project_ProjectidProject",
                        column: x => x.ProjectidProject,
                        principalTable: "Project",
                        principalColumn: "IDPROJECT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttachT",
                columns: table => new
                {
                    IDATTACH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(nullable: true),
                    TYPE = table.Column<string>(nullable: true),
                    BLOB = table.Column<byte>(nullable: false),
                    ExecutionTaskidTask = table.Column<int>(nullable: true),
                    ImpedimentidImpediment = table.Column<int>(nullable: true),
                    KnowledgeidKnowledge = table.Column<int>(nullable: true),
                    NotationidNotation = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachT", x => x.IDATTACH);
                    table.ForeignKey(
                        name: "FK_AttachT_ExecutionTask_ExecutionTaskidTask",
                        column: x => x.ExecutionTaskidTask,
                        principalTable: "ExecutionTask",
                        principalColumn: "IDTASK",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttachT_Impediment_ImpedimentidImpediment",
                        column: x => x.ImpedimentidImpediment,
                        principalTable: "Impediment",
                        principalColumn: "IDIMPEDIMENT",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttachT_Knowledge_KnowledgeidKnowledge",
                        column: x => x.KnowledgeidKnowledge,
                        principalTable: "Knowledge",
                        principalColumn: "IDKNOWLEDGE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttachT_Notation_NotationidNotation",
                        column: x => x.NotationidNotation,
                        principalTable: "Notation",
                        principalColumn: "IDNOTATION",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Backlog",
                columns: table => new
                {
                    IDBACKLOG = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORY = table.Column<string>(nullable: true),
                    PRECEDENCE = table.Column<string>(nullable: true),
                    ESTIMATE = table.Column<string>(nullable: true),
                    IMPORTANCE = table.Column<string>(nullable: true),
                    STORY = table.Column<string>(nullable: true),
                    IDPROJECT = table.Column<int>(nullable: false),
                    IDMOCKUP = table.Column<int>(nullable: false),
                    IDSTATUS = table.Column<int>(nullable: false),
                    ExecutionTaskidTask = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backlog", x => x.IDBACKLOG);
                    table.ForeignKey(
                        name: "FK_Backlog_ExecutionTask_ExecutionTaskidTask",
                        column: x => x.ExecutionTaskidTask,
                        principalTable: "ExecutionTask",
                        principalColumn: "IDTASK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttachT_ExecutionTaskidTask",
                table: "AttachT",
                column: "ExecutionTaskidTask");

            migrationBuilder.CreateIndex(
                name: "IX_AttachT_ImpedimentidImpediment",
                table: "AttachT",
                column: "ImpedimentidImpediment");

            migrationBuilder.CreateIndex(
                name: "IX_AttachT_KnowledgeidKnowledge",
                table: "AttachT",
                column: "KnowledgeidKnowledge");

            migrationBuilder.CreateIndex(
                name: "IX_AttachT_NotationidNotation",
                table: "AttachT",
                column: "NotationidNotation");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_ExecutionTaskidTask",
                table: "Backlog",
                column: "ExecutionTaskidTask");

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionTask_ImpedimentidImpediment",
                table: "ExecutionTask",
                column: "ImpedimentidImpediment");

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionTask_KnowledgeidKnowledge",
                table: "ExecutionTask",
                column: "KnowledgeidKnowledge");

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionTask_ProjectidProject",
                table: "ExecutionTask",
                column: "ProjectidProject");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectidProject",
                table: "ProjectUser",
                column: "ProjectidProject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AttachT");

            migrationBuilder.DropTable(
                name: "Backlog");

            migrationBuilder.DropTable(
                name: "Mockup");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "ProjectTeam");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Notation");

            migrationBuilder.DropTable(
                name: "ExecutionTask");

            migrationBuilder.DropTable(
                name: "Impediment");

            migrationBuilder.DropTable(
                name: "Knowledge");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
