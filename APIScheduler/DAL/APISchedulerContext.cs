using APIScheduler.DAL.Tables;
using Microsoft.EntityFrameworkCore;

namespace APIScheduler.DAL
{
    public class APISchedulerContext : DbContext
    {
        public APISchedulerContext()
        {
        }

        //public APISchedulerContext(DbContextOptions<APISchedulerContext> options)
        //    : base(options)
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
            });

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ANURAG-KATIYAR\\SQLEXPRESS;Database=APISchedulerDb;Trusted_Connection=True;");
            }
        }
        public virtual DbSet<User> users { get; set; }
    }
}
