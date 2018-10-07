using System.ComponentModel;

namespace ExchangeGame.Domain.Model.Players
{
    public enum PlayerTypeEnum
    {
        [Description("Buys when value is increasing. Sells when value is decreasing")]
        Simple,

        [Description("Uses a neural network to determine wether to buy or sell based on the price history")]
        AI
    }
}