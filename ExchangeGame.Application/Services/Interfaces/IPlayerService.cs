using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Accounts;
using ExchangeGame.Domain.Model.Players;

namespace ExchangeGame.Application.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<Player> GetPlayerAsync(int id);
        Task<ICollection<Player>> GetAllPlayersAsync();
        Task AddPlayerAsync(Player player, decimal startingFunds = 0m);
        Task SetPlayerAsync(int id, Player player);
        Task RemovePlayerAsync(int id);
        Task<Account> GetPlayerAccountAsync(int playerId);
    }
}