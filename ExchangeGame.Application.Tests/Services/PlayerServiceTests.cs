using System.Linq;
using System.Threading.Tasks;
using ExchangeGame.Application.Services.Implementations;
using ExchangeGame.Domain.Model.Accounts;
using ExchangeGame.Domain.Model.Players;
using ExchangeGame.Infrastructure;
using ExchangeGame.Infrastructure.Repositories.Players;
using ExchangeGame.Test.Utils.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace ExchangeGame.Application.Tests.Services
{
    public class PlayerServiceTests
    {
        [Fact]
        public async Task AddPlayerShouldCreateEntity()
        {
            var service = ServiceMocker.MockPlayerService();

            await service.AddPlayerAsync(
                new Player
                {
                    Name = "Javi",
                    Account = new Account()
                });

            var players = await service.GetAllPlayersAsync();

            Assert.NotEmpty(players);

            Assert.Equal("Javi", players.First().Name);
        }
    }
}
