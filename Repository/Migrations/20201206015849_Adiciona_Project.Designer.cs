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
    [Migration("20201206015849_Adiciona_Project")]
    partial class Adiciona_Project
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repository.Models.ProjectTeam", b =>
                {
                    b.Property<int>("idProjectTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDPROJECTTEAM")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idProject")
                        .HasColumnName("IDPROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnName("IDUSER")
                        .HasColumnType("int");

                    b.HasKey("idProjectTeam");

                    b.ToTable("ProjectTeam");
                });

            modelBuilder.Entity("Repository.Models.PROJECT_USER", b =>
                {
                    b.Property<int>("idPROJECT_USER")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDPROJECT_USER")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idProject")
                        .HasColumnName("IDPROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnName("IDUSER")
                        .HasColumnType("int");

                    b.HasKey("idPROJECT_USER");

                    b.HasIndex("idProject");

                    b.HasIndex("idUser");

                    b.ToTable("PROJECT_USER");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Address", b =>
                {
                    b.Property<int>("idAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDADDRESS")
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

                    b.ToTable("Address");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Attach", b =>
                {
                    b.Property<int>("idAttach")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDATTACH")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Blob")
                        .HasColumnName("BLOB")
                        .HasColumnType("tinyint");

                    b.Property<int?>("ExecutionTaskidTask")
                        .HasColumnType("int");

                    b.Property<int?>("ImpedimentidImpediment")
                        .HasColumnType("int");

                    b.Property<int?>("KnowledgeidKnowledge")
                        .HasColumnType("int");

                    b.Property<int?>("AnnotationidAnnotation")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnName("TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAttach");

                    b.HasIndex("ExecutionTaskidTask");

                    b.HasIndex("ImpedimentidImpediment");

                    b.HasIndex("KnowledgeidKnowledge");

                    b.HasIndex("AnnotationidAnnotation");

                    b.ToTable("AttachT");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Backlog", b =>
                {
                    b.Property<int>("idBacklog")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDBACKLOG")
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

                    b.Property<string>("Story")
                        .HasColumnName("STORY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idMockup")
                        .HasColumnName("IDMOCKUP")
                        .HasColumnType("int");

                    b.Property<int>("idProject")
                        .HasColumnName("IDPROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idStatus")
                        .HasColumnName("IDSTATUS")
                        .HasColumnType("int");

                    b.HasKey("idBacklog");

                    b.HasIndex("ExecutionTaskidTask");

                    b.ToTable("Backlog");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.ExecutionTask", b =>
                {
                    b.Property<int>("idTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDTASK")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int?>("ProjectidProject")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnName("WEIGHT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idProject")
                        .HasColumnName("IDPROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idStatus")
                        .HasColumnName("IDSTATUS")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnName("IDUSER")
                        .HasColumnType("int");

                    b.HasKey("idTask");

                    b.HasIndex("ImpedimentidImpediment");

                    b.HasIndex("KnowledgeidKnowledge");

                    b.HasIndex("ProjectidProject");

                    b.ToTable("ExecutionTask");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Impediment", b =>
                {
                    b.Property<int>("idImpediment")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDIMPEDIMENT")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnName("IDUSER")
                        .HasColumnType("int");

                    b.HasKey("idImpediment");

                    b.ToTable("Impediment");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Knowledge", b =>
                {
                    b.Property<int>("idKnowledge")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDKNOWLEDGE")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idKnowledge");

                    b.ToTable("Knowledge");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Mockup", b =>
                {
                    b.Property<int>("idMockup")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDMOCKUP")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Blob")
                        .HasColumnName("BLOB")
                        .HasColumnType("tinyint");

                    b.Property<string>("Type")
                        .HasColumnName("TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMockup");

                    b.ToTable("Mockup");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Annotation", b =>
                {
                    b.Property<int>("idAnnotation")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDNOTATION")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionCard")
                        .HasColumnName("POSITIONCARD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnName("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idProject")
                        .HasColumnName("IDPROJECT")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnName("IDUSER")
                        .HasColumnType("int");

                    b.HasKey("idAnnotation");

                    b.ToTable("Annotation");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Profile", b =>
                {
                    b.Property<int>("idProfile")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDPROFILE")
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

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Project", b =>
                {
                    b.Property<int>("idProject")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDPROJECT")
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

                    b.HasKey("idProject");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Status", b =>
                {
                    b.Property<int>("idStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDSTATUS")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnName("TIPO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idStatus");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Team", b =>
                {
                    b.Property<int>("idTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDTEAM")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTeam");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.User", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDUSER")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnName("LOGIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnName("PASSWORD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idAddress")
                        .HasColumnName("IDADDRESS")
                        .HasColumnType("int");

                    b.Property<int?>("idProfile")
                        .HasColumnName("IDPROFILE")
                        .HasColumnType("int");

                    b.HasKey("idUser");

                    b.HasIndex("idAddress");

                    b.HasIndex("idProfile");

                    b.ToTable("User");
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

            modelBuilder.Entity("TeamAnnotationAPI.Models.Attach", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.ExecutionTask", null)
                        .WithMany("Attachments")
                        .HasForeignKey("ExecutionTaskidTask");

                    b.HasOne("TeamAnnotationAPI.Models.Impediment", null)
                        .WithMany("Attachments")
                        .HasForeignKey("ImpedimentidImpediment");

                    b.HasOne("TeamAnnotationAPI.Models.Knowledge", null)
                        .WithMany("Attachments")
                        .HasForeignKey("KnowledgeidKnowledge");

                    b.HasOne("TeamAnnotationAPI.Models.Annotation", null)
                        .WithMany("Attachments")
                        .HasForeignKey("AnnotationidAnnotation");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.Backlog", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.ExecutionTask", null)
                        .WithMany("Backlogs")
                        .HasForeignKey("ExecutionTaskidTask");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.ExecutionTask", b =>
                {
                    b.HasOne("TeamAnnotationAPI.Models.Impediment", null)
                        .WithMany("Tasks")
                        .HasForeignKey("ImpedimentidImpediment");

                    b.HasOne("TeamAnnotationAPI.Models.Knowledge", null)
                        .WithMany("Tasks")
                        .HasForeignKey("KnowledgeidKnowledge");

                    b.HasOne("TeamAnnotationAPI.Models.Project", null)
                        .WithMany("ExecutionTasks")
                        .HasForeignKey("ProjectidProject");
                });

            modelBuilder.Entity("TeamAnnotationAPI.Models.User", b =>
                {
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
