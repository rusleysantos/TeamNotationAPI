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
                    idAddress = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    Countrie = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.idAddress);
                });

            migrationBuilder.CreateTable(
                name: "Knowledge",
                columns: table => new
                {
                    idKnowledge = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledge", x => x.idKnowledge);
                });

            migrationBuilder.CreateTable(
                name: "Mockup",
                columns: table => new
                {
                    idMockup = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    Blob = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mockup", x => x.idMockup);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    idProfile = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.idProfile);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    idProject = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PercentDone = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.idProject);
                });

            migrationBuilder.CreateTable(
                name: "StatusBacklog",
                columns: table => new
                {
                    idStatusBacklog = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusBacklog", x => x.idStatusBacklog);
                });

            migrationBuilder.CreateTable(
                name: "StatusTask",
                columns: table => new
                {
                    idStatus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTask", x => x.idStatus);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    idTeam = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProjectidProject = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.idTeam);
                    table.ForeignKey(
                        name: "FK_Team_Project_ProjectidProject",
                        column: x => x.ProjectidProject,
                        principalTable: "Project",
                        principalColumn: "idProject",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    idUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    AddressidAddress = table.Column<int>(nullable: true),
                    ProfileidProfile = table.Column<int>(nullable: true),
                    ProjectidProject = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.idUser);
                    table.ForeignKey(
                        name: "FK_User_Address_AddressidAddress",
                        column: x => x.AddressidAddress,
                        principalTable: "Address",
                        principalColumn: "idAddress",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Profile_ProfileidProfile",
                        column: x => x.ProfileidProfile,
                        principalTable: "Profile",
                        principalColumn: "idProfile",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Project_ProjectidProject",
                        column: x => x.ProjectidProject,
                        principalTable: "Project",
                        principalColumn: "idProject",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Impediment",
                columns: table => new
                {
                    idImpediment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UseridUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impediment", x => x.idImpediment);
                    table.ForeignKey(
                        name: "FK_Impediment_User_UseridUser",
                        column: x => x.UseridUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notation",
                columns: table => new
                {
                    idNotation = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UseridUser = table.Column<int>(nullable: true),
                    ProjectidProject = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notation", x => x.idNotation);
                    table.ForeignKey(
                        name: "FK_Notation_Project_ProjectidProject",
                        column: x => x.ProjectidProject,
                        principalTable: "Project",
                        principalColumn: "idProject",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notation_User_UseridUser",
                        column: x => x.UseridUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    idTask = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Effort = table.Column<string>(nullable: true),
                    StatusidStatus = table.Column<int>(nullable: true),
                    MainTaskidTask = table.Column<int>(nullable: true),
                    UseridUser = table.Column<int>(nullable: true),
                    ImpedimentidImpediment = table.Column<int>(nullable: true),
                    KnowledgeidKnowledge = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.idTask);
                    table.ForeignKey(
                        name: "FK_Task_Impediment_ImpedimentidImpediment",
                        column: x => x.ImpedimentidImpediment,
                        principalTable: "Impediment",
                        principalColumn: "idImpediment",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_Knowledge_KnowledgeidKnowledge",
                        column: x => x.KnowledgeidKnowledge,
                        principalTable: "Knowledge",
                        principalColumn: "idKnowledge",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_Task_MainTaskidTask",
                        column: x => x.MainTaskidTask,
                        principalTable: "Task",
                        principalColumn: "idTask",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_StatusTask_StatusidStatus",
                        column: x => x.StatusidStatus,
                        principalTable: "StatusTask",
                        principalColumn: "idStatus",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_User_UseridUser",
                        column: x => x.UseridUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttachT",
                columns: table => new
                {
                    idAttach = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Blob = table.Column<byte>(nullable: false),
                    ImpedimentidImpediment = table.Column<int>(nullable: true),
                    KnowledgeidKnowledge = table.Column<int>(nullable: true),
                    NotationidNotation = table.Column<int>(nullable: true),
                    TaskidTask = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachT", x => x.idAttach);
                    table.ForeignKey(
                        name: "FK_AttachT_Impediment_ImpedimentidImpediment",
                        column: x => x.ImpedimentidImpediment,
                        principalTable: "Impediment",
                        principalColumn: "idImpediment",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttachT_Knowledge_KnowledgeidKnowledge",
                        column: x => x.KnowledgeidKnowledge,
                        principalTable: "Knowledge",
                        principalColumn: "idKnowledge",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttachT_Notation_NotationidNotation",
                        column: x => x.NotationidNotation,
                        principalTable: "Notation",
                        principalColumn: "idNotation",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AttachT_Task_TaskidTask",
                        column: x => x.TaskidTask,
                        principalTable: "Task",
                        principalColumn: "idTask",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Backlog",
                columns: table => new
                {
                    idBacklog = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(nullable: false),
                    Precedence = table.Column<int>(nullable: false),
                    Estimate = table.Column<int>(nullable: false),
                    Importance = table.Column<int>(nullable: false),
                    Story = table.Column<int>(nullable: false),
                    ProjectidProject = table.Column<int>(nullable: true),
                    MockupidMockup = table.Column<int>(nullable: true),
                    StatusidStatusBacklog = table.Column<int>(nullable: true),
                    TaskidTask = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backlog", x => x.idBacklog);
                    table.ForeignKey(
                        name: "FK_Backlog_Mockup_MockupidMockup",
                        column: x => x.MockupidMockup,
                        principalTable: "Mockup",
                        principalColumn: "idMockup",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Backlog_Project_ProjectidProject",
                        column: x => x.ProjectidProject,
                        principalTable: "Project",
                        principalColumn: "idProject",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Backlog_StatusBacklog_StatusidStatusBacklog",
                        column: x => x.StatusidStatusBacklog,
                        principalTable: "StatusBacklog",
                        principalColumn: "idStatusBacklog",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Backlog_Task_TaskidTask",
                        column: x => x.TaskidTask,
                        principalTable: "Task",
                        principalColumn: "idTask",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_AttachT_TaskidTask",
                table: "AttachT",
                column: "TaskidTask");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_MockupidMockup",
                table: "Backlog",
                column: "MockupidMockup");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_ProjectidProject",
                table: "Backlog",
                column: "ProjectidProject");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_StatusidStatusBacklog",
                table: "Backlog",
                column: "StatusidStatusBacklog");

            migrationBuilder.CreateIndex(
                name: "IX_Backlog_TaskidTask",
                table: "Backlog",
                column: "TaskidTask");

            migrationBuilder.CreateIndex(
                name: "IX_Impediment_UseridUser",
                table: "Impediment",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_Notation_ProjectidProject",
                table: "Notation",
                column: "ProjectidProject");

            migrationBuilder.CreateIndex(
                name: "IX_Notation_UseridUser",
                table: "Notation",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_Task_ImpedimentidImpediment",
                table: "Task",
                column: "ImpedimentidImpediment");

            migrationBuilder.CreateIndex(
                name: "IX_Task_KnowledgeidKnowledge",
                table: "Task",
                column: "KnowledgeidKnowledge");

            migrationBuilder.CreateIndex(
                name: "IX_Task_MainTaskidTask",
                table: "Task",
                column: "MainTaskidTask");

            migrationBuilder.CreateIndex(
                name: "IX_Task_StatusidStatus",
                table: "Task",
                column: "StatusidStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Task_UseridUser",
                table: "Task",
                column: "UseridUser");

            migrationBuilder.CreateIndex(
                name: "IX_Team_ProjectidProject",
                table: "Team",
                column: "ProjectidProject");

            migrationBuilder.CreateIndex(
                name: "IX_User_AddressidAddress",
                table: "User",
                column: "AddressidAddress");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProfileidProfile",
                table: "User",
                column: "ProfileidProfile");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProjectidProject",
                table: "User",
                column: "ProjectidProject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttachT");

            migrationBuilder.DropTable(
                name: "Backlog");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Notation");

            migrationBuilder.DropTable(
                name: "Mockup");

            migrationBuilder.DropTable(
                name: "StatusBacklog");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "Impediment");

            migrationBuilder.DropTable(
                name: "Knowledge");

            migrationBuilder.DropTable(
                name: "StatusTask");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
