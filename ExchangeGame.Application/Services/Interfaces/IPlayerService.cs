using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Player;

namespace ExchangeGame.Application.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<Player> GetPlayerAsync(int id);
        Task<ICollection<Player>> GetAllPlayersAsync();
        Task AddPlayerAsync(Player player);
        Task SetPlayerAsync(int id, Player player);
        Task RemovePlayerAsync(int id);
    }
}