using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TeamNotationAPI.Models;

namespace Repository.Models
{
    public class NotationContext : DbContext
    {

        [Key]
        public int DbContextId { get; set; }

        [NotMapped]
        private IConfiguration _conf { get; set; }

        public NotationContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _conf = configuration;
        }

        public NotationContext() : base()
        {

        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conf.GetConnectionString("myconn"));
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Attach> AttachT { get; set; }
        public DbSet<Backlog> Backlog { get; set; }
        public DbSet<Impediment> Impediment { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<Mockup> Mockup { get; set; }
        public DbSet<Notation> Notation { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<ExecutionTask> ExecutionTask { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ProjectUser> ProjectUser { get; set; }
        public DbSet<ProjectTeam> ProjectTeam { get; set; }

    }
}
