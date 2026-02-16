namespace NateParker.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models.Quilmes;

    public class QuilmesDataContext : DbContext
    {
        public QuilmesDataContext(DbContextOptions<QuilmesDataContext> options) : base(options)
        {
        }
        
        public DbSet<Appearance> Appearances { get; set; }
        public DbSet<Assist> Assists { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Opponent> Opponents { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Season> Seasons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appearance>().ToTable("Appearance");
            modelBuilder.Entity<Assist>().ToTable("Assist");
            modelBuilder.Entity<Card>().ToTable("Card");
            modelBuilder.Entity<CardType>().ToTable("CardType");
            modelBuilder.Entity<Division>().ToTable("Division");
            modelBuilder.Entity<Goal>().ToTable("Goal");
            modelBuilder.Entity<Match>().ToTable("Match");
            modelBuilder.Entity<Opponent>().ToTable("Opponent");
            modelBuilder.Entity<Player>().ToTable("Player");
            modelBuilder.Entity<Season>().ToTable("Season");
        }
    }
}
