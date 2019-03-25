using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
namespace slack.Models
{
    public class Context : DbContext
    {
        public Context() : base("Context") { }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Seminar> Seminars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}