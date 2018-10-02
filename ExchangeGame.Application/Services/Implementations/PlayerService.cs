using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Player;
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

        public async Task AddPlayerAsync(Player player)
        {
            await _playerRepository.Create(player);
        }

        public async Task SetPlayerAsync(int id, Player player)
        {
            await _playerRepository.Update(id, player);
        }

        public async Task RemovePlayerAsync(int id)
        {
            await _playerRepository.Delete(id);
        }
    }
}