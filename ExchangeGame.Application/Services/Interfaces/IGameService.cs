using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Games;
using ExchangeGame.Domain.Model.Players;

namespace ExchangeGame.Application.Services.Interfaces
{
    public interface IGameService
    {
        Task<int> CreateGameAsync(Game game);
        Task<ICollection<Game>> GetAllGamesAsync();
        Task UpdateGameAsync(int gameId, Game game);
        Task<int> AddPlayerAsync(int gameId, Player player);
        Task RemovePlayerAsync(int gameId, int playerId);
        Task<Game> GetGameAsync(int gameId);
        Task DeleteGameAsync(int gameId);
    }
}