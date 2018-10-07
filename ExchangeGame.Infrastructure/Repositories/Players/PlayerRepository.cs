using ExchangeGame.Domain.Model.Players;
using ExchangeGame.Application.Repositories.Players;
using Microsoft.EntityFrameworkCore;

namespace ExchangeGame.Infrastructure.Repositories.Players
{
    public class PlayerRepository : EntityFrameworkRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}