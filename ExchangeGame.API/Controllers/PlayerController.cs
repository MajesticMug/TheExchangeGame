using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Players;
using ExchangeGame.Application.Services.Interfaces;
using ExchangeGame.Domain.Model.Accounts;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeGame.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("{playerId:int}/account")]
        public async Task<Account> GetPlayerAccount(int playerId)
        {
            return await _playerService.GetPlayerAccountAsync(playerId);
        }

        // GET: api/Player
        [HttpGet]
        public async Task<IEnumerable<Player>> Get()
        {
            return await _playerService.GetAllPlayersAsync();
        }

        // GET: api/Player/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Player> Get(int id)
        {
            return await _playerService.GetPlayerAsync(id);
        }

        // POST: api/Player
        [HttpPost("{startingFunds}")]
        public async Task Post(decimal startingFunds, [FromBody] Player player)
        {
            await _playerService.AddPlayerAsync(player, startingFunds);
        }

        // PUT: api/Player/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Player player)
        {
            await _playerService.SetPlayerAsync(id, player);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _playerService.RemovePlayerAsync(id);
        }
    }
}
