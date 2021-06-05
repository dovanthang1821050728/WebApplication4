namespace WebApplication4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class thuchanhDbContext : DbContext
    {
        public thuchanhDbContext()
            : base("name=thuchanhDbContext")
        {
        }
        public virtual DbSet<sinhvien> sinhviens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
