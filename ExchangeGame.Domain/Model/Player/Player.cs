using ExchangeGame.Domain.Model.Account;
using ExchangeGame.Domain.Model.Base;

namespace ExchangeGame.Domain.Model.Player
{
    public class Player : BaseModel
    {
        public string Name { get; set; }
        public PlayerType PlayerType { get; set; }
        public BtcAccount BtcAccount { get; set; }
    }
}