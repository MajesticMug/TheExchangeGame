using ExchangeGame.Domain.Model.Base;

namespace ExchangeGame.Domain.Model.Account
{
    public abstract class Account : BaseModel
    {
        public decimal Balance { get; protected set; }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}