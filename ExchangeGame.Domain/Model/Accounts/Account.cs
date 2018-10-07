using ExchangeGame.Domain.Model.Base;
using ExchangeGame.Domain.Model.Markups;
using ExchangeGame.Domain.Model.Players;

namespace ExchangeGame.Domain.Model.Accounts
{
    public class Account : BaseModel
    {
        public decimal Funds { get; private set; }

        public decimal Bitcoins { get; private set; }

        public Player Player { get; set; }
        public int PlayerId { get; set; }

        public Account(decimal funds = 0m, decimal bitcoins = 0m)
        {
            Funds = funds;
            Bitcoins = bitcoins;
        }

        public virtual void WithdrawFunds(decimal amount)
        {
            Funds -= amount;
        }

        public virtual void WithdrawBitcoins(decimal amount)
        {
            Bitcoins -= amount;
        }

        public virtual void DepositFunds(decimal amount)
        {
            Funds += amount;
        }

        public virtual void DepositBitcoins(decimal amount)
        {
            Bitcoins += amount;
        }
    }
}