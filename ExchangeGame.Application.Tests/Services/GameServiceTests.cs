using System.Linq;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Games;
using ExchangeGame.Domain.Model.Players;
using ExchangeGame.Test.Utils.Services;
using Xunit;

namespace ExchangeGame.Application.Tests.Services
{
    public class GameServiceTests
    {
        [Fact]
        public async Task CreateGameShouldAddNewGameToDb()
        {
            var service = ServiceMocker.MockGameService(ServiceMocker.MockDbContext());
            
            var games = await service.GetAllGamesAsync();

            Assert.Empty(games);

            await service.CreateGameAsync(new Game{Name = "test"});

            games = await service.GetAllGamesAsync();

            Assert.NotEmpty(games);

            Assert.Equal("test", games.First().Name);
        }

        [Fact]
        public async Task AddPlayerShouldAddNewPlayer()
        {
            var service = ServiceMocker.MockGameService(ServiceMocker.MockDbContext());

            var gameId = await service.CreateGameAsync(new Game());

            await service.AddPlayerAsync(gameId, new Player {Name = "test"});

            var game = await service.GetGameAsync(gameId);

            Assert.NotEmpty(game.Players);

            Assert.Equal("test", game.Players.First().Name);
        }
    }
}
