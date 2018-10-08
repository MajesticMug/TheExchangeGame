using ExchangeGame.Application.Repositories.Games;
using ExchangeGame.Domain.Model.Games;

namespace ExchangeGame.Infrastructure.Repositories.Games
{
    public class GameRepository : EntityFrameworkRepository<Game>, IGameRepository
    {
        public GameRepository(ExchangeGameDbContext dbContext) : base(dbContext)
        {
        }
    }
}