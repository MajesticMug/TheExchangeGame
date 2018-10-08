using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeGame.Application.Services.Interfaces;
using ExchangeGame.Domain.Model.Games;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeGame.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        // GET: api/Game
        [HttpGet]
        public async Task<IEnumerable<Game>> Get()
        {
            return await _gameService.GetAllGamesAsync();
        }

        // GET: api/Game/5
        [HttpGet("{gameId}", Name = "Get")]
        public async Task<Game> Get(int gameId)
        {
            return await _gameService.GetGameAsync(gameId);
        }

        // POST: api/Game
        [HttpPost]
        public async Task<int> Post([FromBody] Game game)
        {
            return await _gameService.CreateGameAsync(game);
        }

        // PUT: api/Game/5
        [HttpPut("{gameId}")]
        public async Task Put(int gameId, [FromBody] Game game)
        {
            await _gameService.UpdateGameAsync(gameId, game);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{gameId}")]
        public async Task Delete(int gameId)
        {
            await _gameService.DeleteGameAsync(gameId);
        }
    }
}
