using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Players;
using ExchangeGame.Application.Repositories.Players;
using ExchangeGame.Application.Services.Interfaces;

namespace ExchangeGame.Application.Services.Implementations
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<Player> GetPlayerAsync(int id)
        {
            return await _playerRepository.GetById(id);
        }

        public async Task<ICollection<Player>> GetAllPlayersAsync()
        {
            return await _playerRepository.GetAllAsync();
        }
    }
}