﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Models;

namespace Repository.Migrations
{
    [DbContext(typeof(AnnotationContext))]
    [Migration("20220613233235_adiciona_sequene_number")]
    partial class adiciona_sequene_number
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repository.Models.PROJECT_USER", b =>
                {
                    b.Property<int>("idPROJECT_USER")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_PROJECT_USER")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idProject")
                        .HasColumnName("ID_PROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnName("ID_USER")
                        .HasColumnType("int");

                    b.HasKey("idPROJECT_USER");

                    b.HasIndex("idProject");

                    b.HasIndex("idUser");

                    b.ToTable("PROJECT_USER");
                });

            modelBuilder.Entity("Repository.Models.ProjectTeam", b =>
                {
                    b.Property<int>("idProjectTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_PROJECTTEAM")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idProject")
                        .HasColumnName("ID_PROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnName("ID_USER")
                        .HasColumnType("int");

                    b.HasKey("idProjectTeam");

                    b.HasIndex("idProject");

                    b.HasIndex("idUser");

                    b.ToTable("PROJECT_TEAM");
                });

            modelBuilder.Entity("Repository.Models.Sprint", b =>
                {
                    b.Property<int>("idSprint")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_SPRINT")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("End")
                        .HasColumnName("END")
                        .HasColumnType("datetime2");

                    b.Property<string>("Goal")
                        .HasColumnName("GOAL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectidProject")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnName("START")
                        .HasColumnType("datetime2");

                    b.HasKey("idSprint");

                    b.HasIndex("ProjectidProject");

                    b.ToTable("SPRINT");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Address", b =>
                {
                    b.Property<int>("idAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_ADDRESS")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Countrie")
                        .HasColumnName("COUNTRIE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnName("LATITUDE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnName("LONGITUDE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnName("NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnName("STREET")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAddress");

                    b.ToTable("ADDRESS");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Annotation", b =>
                {
                    b.Property<int>("idAnnotation")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_ANNOTATION")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorBackground")
                        .HasColumnName("COLOR_BACKGROUND")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorText")
                        .HasColumnName("COLOR_TEXT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnName("DELETED")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExecutionTaskidTask")
                        .HasColumnType("int");

                    b.Property<string>("PositionCard")
                        .HasColumnName("POSITIONCARD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idProject")
                        .HasColumnName("ID_PROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnName("ID_USER")
                        .HasColumnType("int");

                    b.HasKey("idAnnotation");

                    b.HasIndex("ExecutionTaskidTask");

                    b.HasIndex("idProject");

                    b.HasIndex("idUser");

                    b.ToTable("ANNOTATION");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Attach", b =>
                {
                    b.Property<int>("idAttach")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_ATTACH")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnnotationidAnnotation")
                        .HasColumnType("int");

                    b.Property<byte>("Blob")
                        .HasColumnName("BLOB")
                        .HasColumnType("tinyint");

                    b.Property<int?>("ExecutionTaskidTask")
                        .HasColumnType("int");

                    b.Property<int?>("ImpedimentidImpediment")
                        .HasColumnType("int");

                    b.Property<int?>("KnowledgeidKnowledge")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnName("TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAttach");

                    b.HasIndex("AnnotationidAnnotation");

                    b.HasIndex("ExecutionTaskidTask");

                    b.HasIndex("ImpedimentidImpediment");

                    b.HasIndex("KnowledgeidKnowledge");

                    b.ToTable("ATTACH_T");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Backlog", b =>
                {
                    b.Property<int>("idBacklog")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_BACKLOG")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnName("CATEGORY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estimate")
                        .HasColumnName("ESTIMATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExecutionTaskidTask")
                        .HasColumnType("int");

                    b.Property<string>("Importance")
                        .HasColumnName("IMPORTANCE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precedence")
                        .HasColumnName("PRECEDENCE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusidStatus")
                        .HasColumnType("int");

                    b.Property<string>("Story")
                        .HasColumnName("STORY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idMockup")
                        .HasColumnName("ID_MOCKUP")
                        .HasColumnType("int");

                    b.Property<int>("idProject")
                        .HasColumnName("ID_PROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idStatus")
                        .HasColumnName("ID_STATUS")
                        .HasColumnType("int");

                    b.HasKey("idBacklog");

                    b.HasIndex("ExecutionTaskidTask");

                    b.HasIndex("StatusidStatus");

                    b.HasIndex("idMockup");

                    b.HasIndex("idProject");

                    b.ToTable("BACKLOG");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.ExecutionTask", b =>
                {
                    b.Property<int>("idTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_TASK")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorBackground")
                        .HasColumnName("COLOR_BACKGROUND")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorText")
                        .HasColumnName("COLOR_TEXT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnName("DELETED")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Effort")
                        .HasColumnName("EFFORT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImpedimentidImpediment")
                        .HasColumnType("int");

                    b.Property<int?>("KnowledgeidKnowledge")
                        .HasColumnType("int");

                    b.Property<int>("SequenceNumber")
                        .HasColumnName("SEQUENCE_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnName("WEIGHT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idProject")
                        .HasColumnName("ID_PROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idStatus")
                        .HasColumnName("ID_STATUS")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnName("ID_USER")
                        .HasColumnType("int");

                    b.HasKey("idTask");

                    b.HasIndex("ImpedimentidImpediment");

                    b.HasIndex("KnowledgeidKnowledge");

                    b.HasIndex("idProject");

                    b.HasIndex("idStatus");

                    b.HasIndex("idUser");

                    b.ToTable("EXECUTION_TASK");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Impediment", b =>
                {
                    b.Property<int>("idImpediment")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_IMPEDIMENT")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnName("ID_USER")
                        .HasColumnType("int");

                    b.HasKey("idImpediment");

                    b.HasIndex("idUser");

                    b.ToTable("IMPEDIMENT");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Knowledge", b =>
                {
                    b.Property<int>("idKnowledge")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_KNOWLEDGE")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idKnowledge");

                    b.ToTable("KNOWLEDGE");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Mockup", b =>
                {
                    b.Property<int>("idMockup")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_MOCKUP")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Blob")
                        .HasColumnName("BLOB")
                        .HasColumnType("tinyint");

                    b.Property<string>("Type")
                        .HasColumnName("TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMockup");

                    b.ToTable("MOCKUP");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Profile", b =>
                {
                    b.Property<int>("idProfile")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_PROFILE")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate")
                        .HasColumnName("BIRTHDATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnName("SURNAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProfile");

                    b.ToTable("PROFILE");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Project", b =>
                {
                    b.Property<int>("idProject")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_PROJECT")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PercentDone")
                        .HasColumnName("PERCENTDONE")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idTeam")
                        .HasColumnName("ID_TEAM")
                        .HasColumnType("int");

                    b.HasKey("idProject");

                    b.HasIndex("idTeam");

                    b.ToTable("PROJECT");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Status", b =>
                {
                    b.Property<int>("idStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_STATUS")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnName("TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idStatus");

                    b.ToTable("STATUS");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Team", b =>
                {
                    b.Property<int>("idTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_TEAM")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTeam");

                    b.ToTable("TEAM");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.User", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_USER")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnName("LOGIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnName("PASSWORD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SprintidSprint")
                        .HasColumnType("int");

                    b.Property<int?>("TeamidTeam")
                        .HasColumnType("int");

                    b.Property<int?>("idAddress")
                        .HasColumnName("ID_ADDRESS")
                        .HasColumnType("int");

                    b.Property<int?>("idProfile")
                        .HasColumnName("ID_PROFILE")
                        .HasColumnType("int");

                    b.HasKey("idUser");

                    b.HasIndex("SprintidSprint");

                    b.HasIndex("TeamidTeam");

                    b.HasIndex("idAddress");

                    b.HasIndex("idProfile");

                    b.ToTable("USER");
                });

            modelBuilder.Entity("Repository.Models.PROJECT_USER", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("idProject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAnnotationAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repository.Models.ProjectTeam", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("idProject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAnnotationAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repository.Models.Sprint", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.Project", null)
                        .WithMany("Sprints")
                        .HasForeignKey("ProjectidProject");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Annotation", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.ExecutionTask", null)
                        .WithMany("Annotations")
                        .HasForeignKey("ExecutionTaskidTask");

                    b.HasOne("TeamAnnotationAPI.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("idProject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAnnotationAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Attach", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.Annotation", null)
                        .WithMany("Attachments")
                        .HasForeignKey("AnnotationidAnnotation");

                    b.HasOne("TeamAnnotationAPI.Models.ExecutionTask", null)
                        .WithMany("Attachments")
                        .HasForeignKey("ExecutionTaskidTask");

                    b.HasOne("TeamAnnotationAPI.Models.Impediment", null)
                        .WithMany("Attachments")
                        .HasForeignKey("ImpedimentidImpediment");

                    b.HasOne("TeamAnnotationAPI.Models.Knowledge", null)
                        .WithMany("Attachments")
                        .HasForeignKey("KnowledgeidKnowledge");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Backlog", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.ExecutionTask", null)
                        .WithMany("Backlogs")
                        .HasForeignKey("ExecutionTaskidTask");

                    b.HasOne("TeamAnnotationAPI.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusidStatus");

                    b.HasOne("TeamAnnotationAPI.Models.Mockup", "Mockup")
                        .WithMany()
                        .HasForeignKey("idMockup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAnnotationAPI.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("idProject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.ExecutionTask", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.Impediment", null)
                        .WithMany("Tasks")
                        .HasForeignKey("ImpedimentidImpediment");

                    b.HasOne("TeamAnnotationAPI.Models.Knowledge", null)
                        .WithMany("Tasks")
                        .HasForeignKey("KnowledgeidKnowledge");

                    b.HasOne("TeamAnnotationAPI.Models.Project", "Project")
                        .WithMany("ExecutionTasks")
                        .HasForeignKey("idProject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAnnotationAPI.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("idStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAnnotationAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Impediment", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Project", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("idTeam");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.User", b =>
                {
                    b.HasOne("Repository.Models.Sprint", null)
                        .WithMany("Executors")
                        .HasForeignKey("SprintidSprint");

                    b.HasOne("TeamAnnotationAPI.Models.Team", null)
                        .WithMany("TeamMembers")
                        .HasForeignKey("TeamidTeam");

                    b.HasOne("TeamAnnotationAPI.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("idAddress");

                    b.HasOne("TeamAnnotationAPI.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("idProfile");
                });
#pragma warning restore 612, 618
        }
    }
}
