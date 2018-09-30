using ExchangeGame.Domain.Model.Account;
using ExchangeGame.Domain.Model.Base;
using ExchangeGame.Domain.Model.Player;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace ExchangeGame.Infrastructure
{
    public class ExchangeGameDbContext : DbContext
    {
        public ExchangeGameDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<PlayerType> PlayerTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}