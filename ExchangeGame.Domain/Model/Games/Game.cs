using System;
using System.Collections.Generic;
using ExchangeGame.Domain.Model.Base;
using ExchangeGame.Domain.Model.Markups;
using ExchangeGame.Domain.Model.Players;

namespace ExchangeGame.Domain.Model.Games
{
    public class Game : BaseModel, IAggregateRoot
    {
        private readonly List<Player> _players = new List<Player>();

        public IReadOnlyCollection<Player> Players => _players.AsReadOnly();

        public string Name { get; set; }

        public DateTime StartDate { get; } = DateTime.Now;

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public void RemovePlayer(int playerId)
        {
            _players.RemoveAll(player => player.Id == playerId);
        }
    }
}