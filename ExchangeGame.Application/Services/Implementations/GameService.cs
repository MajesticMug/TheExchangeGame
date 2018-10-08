using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Application.Repositories.Games;
using ExchangeGame.Application.Services.Interfaces;
using ExchangeGame.Domain.Model.Games;
using ExchangeGame.Domain.Model.Players;

namespace ExchangeGame.Application.Services.Implementations
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<int> CreateGameAsync(Game game)
        {
            return await _gameRepository.Create(game);
        }

        public async Task<ICollection<Game>> GetAllGamesAsync()
        {
            return await _gameRepository.GetAllAsync();
        }

        public async Task UpdateGameAsync(int gameId, Game game)
        {
            await _gameRepository.Update(gameId, game);
        }

        public async Task<int> AddPlayerAsync(int gameId, Player player)
        {
            var game = await _gameRepository.GetById(gameId);

            game.AddPlayer(player);

            await _gameRepository.Update(gameId, game);

            return player.Id;
        }

        public async Task RemovePlayerAsync(int gameId, int playerId)
        {
            var game = await _gameRepository.GetById(gameId);

            game.RemovePlayer(playerId);

            await _gameRepository.Update(gameId, game);
        }

        public async Task<Game> GetGameAsync(int gameId)
        {
            return await _gameRepository.GetById(gameId);
        }

        public async Task DeleteGameAsync(int gameId)
        {
            await _gameRepository.DeleteAsync(gameId);
        }
    }
}