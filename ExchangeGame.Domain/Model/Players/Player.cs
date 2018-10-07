using ExchangeGame.Domain.Model.Accounts;
using ExchangeGame.Domain.Model.Base;
using ExchangeGame.Domain.Model.Markups;

namespace ExchangeGame.Domain.Model.Players
{
    public class Player : BaseModel, IAggregateRoot
    {
        public string Name { get; set; }

        public PlayerType PlayerType { get; set; }

        public int AccountId { get; set; }

        public Account Account { get; set; }
    }
}