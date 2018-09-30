using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Player;

namespace ExchangeGame.Domain.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<Player> GetPlayer(int id);
        Task<ICollection<Player>> GetAllPlayersAsync();
        Task CreatePlayer(Player player);
    }
}