using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using TestingProject.Models;

namespace TestingProject.App_Start
{
    public class DBContext : DbContext
    {
        // Access the different collections with the firebase firestore database
        public DBContext()
           : base("DBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Businessperson> Businesspeople { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
    }
}