using System;
using ExchangeGame.Application.Repositories.Games;
using ExchangeGame.Application.Repositories.Players;
using ExchangeGame.Application.Services.Implementations;
using ExchangeGame.Application.Services.Interfaces;
using ExchangeGame.Infrastructure;
using ExchangeGame.Infrastructure.Repositories.Games;
using ExchangeGame.Infrastructure.Repositories.Players;
using Microsoft.EntityFrameworkCore;

namespace ExchangeGame.Test.Utils.Services
{
    public class ServiceMocker
    {
        public static IPlayerService MockPlayerService(ExchangeGameDbContext dbContext)
        {
            return new PlayerService(MockPlayerRepository(dbContext));
        }

        public static IGameService MockGameService(ExchangeGameDbContext dbContext)
        {
            return new GameService(MockGameRepository(dbContext));
        }

        public static ExchangeGameDbContext MockDbContext(string dbName = null)
        {
            return new ExchangeGameDbContext(
                new DbContextOptionsBuilder<ExchangeGameDbContext>().UseInMemoryDatabase(
                    dbName ?? Guid.NewGuid().ToString()).Options);
        }

        public static IPlayerRepository MockPlayerRepository(ExchangeGameDbContext dbContext)
        {
            return new PlayerRepository(dbContext);
        }

        public static IGameRepository MockGameRepository(ExchangeGameDbContext dbContext)
        {
            return new GameRepository(dbContext);
        }
    }
}