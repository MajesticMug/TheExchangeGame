using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Players;

namespace ExchangeGame.Application.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<Player> GetPlayerAsync(int id);
        Task<ICollection<Player>> GetAllPlayersAsync();
    }
}