using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test1014.Models
{
    public partial class test1014_Context : DbContext
    {
        public test1014_Context()
            : base("name=test1014")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Member>Members { get; set; }
    }
}
