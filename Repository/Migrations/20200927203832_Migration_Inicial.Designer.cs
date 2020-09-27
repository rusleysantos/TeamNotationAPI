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
    [DbContext(typeof(NotationContext))]
    [Migration("20200927203832_Migration_Inicial")]
    partial class Migration_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeamNotationAPI.Models.Address", b =>
                {
                    b.Property<int>("idAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Countrie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAddress");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Attach", b =>
                {
                    b.Property<int>("idAttach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Blob")
                        .HasColumnType("tinyint");

                    b.Property<int?>("ImpedimentidImpediment")
                        .HasColumnType("int");

                    b.Property<int?>("KnowledgeidKnowledge")
                        .HasColumnType("int");

                    b.Property<int?>("NotationidNotation")
                        .HasColumnType("int");

                    b.Property<int?>("TaskidTask")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAttach");

                    b.HasIndex("ImpedimentidImpediment");

                    b.HasIndex("KnowledgeidKnowledge");

                    b.HasIndex("NotationidNotation");

                    b.HasIndex("TaskidTask");

                    b.ToTable("AttachT");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Backlog", b =>
                {
                    b.Property<int>("idBacklog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Estimate")
                        .HasColumnType("int");

                    b.Property<int>("Importance")
                        .HasColumnType("int");

                    b.Property<int?>("MockupidMockup")
                        .HasColumnType("int");

                    b.Property<int>("Precedence")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectidProject")
                        .HasColumnType("int");

                    b.Property<int?>("StatusidStatusBacklog")
                        .HasColumnType("int");

                    b.Property<int>("Story")
                        .HasColumnType("int");

                    b.Property<int?>("TaskidTask")
                        .HasColumnType("int");

                    b.HasKey("idBacklog");

                    b.HasIndex("MockupidMockup");

                    b.HasIndex("ProjectidProject");

                    b.HasIndex("StatusidStatusBacklog");

                    b.HasIndex("TaskidTask");

                    b.ToTable("Backlog");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Impediment", b =>
                {
                    b.Property<int>("idImpediment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.HasKey("idImpediment");

                    b.HasIndex("UseridUser");

                    b.ToTable("Impediment");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Knowledge", b =>
                {
                    b.Property<int>("idKnowledge")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idKnowledge");

                    b.ToTable("Knowledge");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Mockup", b =>
                {
                    b.Property<int>("idMockup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Blob")
                        .HasColumnType("tinyint");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMockup");

                    b.ToTable("Mockup");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Notation", b =>
                {
                    b.Property<int>("idNotation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectidProject")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.HasKey("idNotation");

                    b.HasIndex("ProjectidProject");

                    b.HasIndex("UseridUser");

                    b.ToTable("Notation");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Profile", b =>
                {
                    b.Property<int>("idProfile")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProfile");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Project", b =>
                {
                    b.Property<int>("idProject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PercentDone")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProject");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.StatusBacklog", b =>
                {
                    b.Property<int>("idStatusBacklog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idStatusBacklog");

                    b.ToTable("StatusBacklog");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.StatusTask", b =>
                {
                    b.Property<int>("idStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idStatus");

                    b.ToTable("StatusTask");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Task", b =>
                {
                    b.Property<int>("idTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Effort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImpedimentidImpediment")
                        .HasColumnType("int");

                    b.Property<int?>("KnowledgeidKnowledge")
                        .HasColumnType("int");

                    b.Property<int?>("MainTaskidTask")
                        .HasColumnType("int");

                    b.Property<int?>("StatusidStatus")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTask");

                    b.HasIndex("ImpedimentidImpediment");

                    b.HasIndex("KnowledgeidKnowledge");

                    b.HasIndex("MainTaskidTask");

                    b.HasIndex("StatusidStatus");

                    b.HasIndex("UseridUser");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Team", b =>
                {
                    b.Property<int>("idTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectidProject")
                        .HasColumnType("int");

                    b.HasKey("idTeam");

                    b.HasIndex("ProjectidProject");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.User", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressidAddress")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfileidProfile")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectidProject")
                        .HasColumnType("int");

                    b.HasKey("idUser");

                    b.HasIndex("AddressidAddress");

                    b.HasIndex("ProfileidProfile");

                    b.HasIndex("ProjectidProject");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Attach", b =>
                {
                    b.HasOne("TeamNotationAPI.Models.Impediment", null)
                        .WithMany("Attachments")
                        .HasForeignKey("ImpedimentidImpediment");

                    b.HasOne("TeamNotationAPI.Models.Knowledge", null)
                        .WithMany("Attachments")
                        .HasForeignKey("KnowledgeidKnowledge");

                    b.HasOne("TeamNotationAPI.Models.Notation", null)
                        .WithMany("Attachments")
                        .HasForeignKey("NotationidNotation");

                    b.HasOne("TeamNotationAPI.Models.Task", null)
                        .WithMany("Attachments")
                        .HasForeignKey("TaskidTask");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Backlog", b =>
                {
                    b.HasOne("TeamNotationAPI.Models.Mockup", "Mockup")
                        .WithMany()
                        .HasForeignKey("MockupidMockup");

                    b.HasOne("TeamNotationAPI.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectidProject");

                    b.HasOne("TeamNotationAPI.Models.StatusBacklog", "Status")
                        .WithMany()
                        .HasForeignKey("StatusidStatusBacklog");

                    b.HasOne("TeamNotationAPI.Models.Task", null)
                        .WithMany("Backlogs")
                        .HasForeignKey("TaskidTask");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Impediment", b =>
                {
                    b.HasOne("TeamNotationAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Notation", b =>
                {
                    b.HasOne("TeamNotationAPI.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectidProject");

                    b.HasOne("TeamNotationAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Task", b =>
                {
                    b.HasOne("TeamNotationAPI.Models.Impediment", null)
                        .WithMany("Tasks")
                        .HasForeignKey("ImpedimentidImpediment");

                    b.HasOne("TeamNotationAPI.Models.Knowledge", null)
                        .WithMany("Tasks")
                        .HasForeignKey("KnowledgeidKnowledge");

                    b.HasOne("TeamNotationAPI.Models.Task", "MainTask")
                        .WithMany()
                        .HasForeignKey("MainTaskidTask");

                    b.HasOne("TeamNotationAPI.Models.StatusTask", "Status")
                        .WithMany()
                        .HasForeignKey("StatusidStatus");

                    b.HasOne("TeamNotationAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.Team", b =>
                {
                    b.HasOne("TeamNotationAPI.Models.Project", null)
                        .WithMany("Team")
                        .HasForeignKey("ProjectidProject");
                });

            modelBuilder.Entity("TeamNotationAPI.Models.User", b =>
                {
                    b.HasOne("TeamNotationAPI.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressidAddress");

                    b.HasOne("TeamNotationAPI.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileidProfile");

                    b.HasOne("TeamNotationAPI.Models.Project", null)
                        .WithMany("User")
                        .HasForeignKey("ProjectidProject");
                });
#pragma warning restore 612, 618
        }
    }
}
