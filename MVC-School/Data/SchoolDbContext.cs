using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_School.Models;

namespace MVC_School.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Studenten { get; set; }
        public DbSet<Locatie> Locaties { get; set; }
<<<<<<< Updated upstream
=======
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<Vak> Vakken { get; set; }
        public DbSet<VakStudent> VakStudenten { get; set; }
>>>>>>> Stashed changes

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<VakStudent>()
                .HasKey(vs => new { vs.StudentId, vs.VakId });
        }
    }
}

