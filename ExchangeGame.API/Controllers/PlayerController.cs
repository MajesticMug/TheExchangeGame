using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Player;
using ExchangeGame.Application.Services.Interfaces;
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
            return await _playerService.GetPlayer(id);
        }

        // POST: api/Player
        [HttpPost]
        public async Task Post([FromBody] Player value)
        {

        }

        // PUT: api/Player/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Player value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

        }
    }
}
