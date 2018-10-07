using ExchangeGame.Application.Services.Implementations;
using ExchangeGame.Application.Services.Interfaces;
using ExchangeGame.Infrastructure;
using ExchangeGame.Infrastructure.Repositories.Players;
using Microsoft.EntityFrameworkCore;

namespace ExchangeGame.Test.Utils.Services
{
    public class ServiceMocker
    {
        public static IPlayerService MockPlayerService()
        {
            var dbContext = new ExchangeGameDbContext(
                new DbContextOptionsBuilder<ExchangeGameDbContext>().UseInMemoryDatabase(
                    "TestDb").Options);

            var repo = new PlayerRepository(dbContext);

            var service = new PlayerService(repo);

            return service;
        }
    }
}