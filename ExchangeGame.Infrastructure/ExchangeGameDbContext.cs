using ExchangeGame.Domain.Model.Accounts;
using ExchangeGame.Domain.Model.Games;
using ExchangeGame.Domain.Model.Players;
using Microsoft.EntityFrameworkCore;

namespace ExchangeGame.Infrastructure
{
    public class ExchangeGameDbContext : DbContext
    {
        public ExchangeGameDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<PlayerType> PlayerTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne<Account>()
                .WithOne(account => account.Player)
                .HasForeignKey<Player>(player => player.AccountId);

            modelBuilder.Entity<Player>()
                .HasOne<Game>()
                .WithMany(game => game.Players)
                .HasForeignKey(player => player.GameId);

            base.OnModelCreating(modelBuilder);
        }
    }
}