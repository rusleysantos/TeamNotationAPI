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
            optionsBuilder.UseSqlServer(_conf.GetConnectionString("ConnDB"));
        }

        public DbSet<Address> ADDRESS { get; set; }
        public DbSet<Attach> ATTACH_T { get; set; }
        public DbSet<Backlog> BACKLOG { get; set; }
        public DbSet<Impediment> IMPEDIMENT { get; set; }
        public DbSet<Knowledge> KNOWLEDGE { get; set; }
        public DbSet<Mockup> MOCKUP { get; set; }
        public DbSet<Notation> NOTATION { get; set; }
        public DbSet<Profile> PROFILE { get; set; }
        public DbSet<Project> PROJECT { get; set; }
        public DbSet<Status> STATUS { get; set; }
        public DbSet<ExecutionTask> EXECUTION_TASK { get; set; }
        public DbSet<Team> TEAM { get; set; }
        public DbSet<User> USER { get; set; }
        public DbSet<PROJECT_USER> PROJECT_USER { get; set; }
        public DbSet<ProjectTeam> PROJECT_TEAM { get; set; }

    }
}
