namespace NateParker.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models.Quilmes;

    public class QuilmesDataContext : DbContext
    {
        public QuilmesDataContext(DbContextOptions<QuilmesDataContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().ToTable("Player");
        }
    }
}
