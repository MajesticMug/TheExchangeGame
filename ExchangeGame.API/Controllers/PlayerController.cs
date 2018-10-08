using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Players;
using ExchangeGame.Application.Services.Interfaces;
using ExchangeGame.Domain.Model.Accounts;
using Microsoft.AspNetCore.Cors;
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
    }
}
