using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ExchangeGame.Domain.Model.Base;
using ExchangeGame.Domain.Utils;

namespace ExchangeGame.Domain.Model.Players
{
    public class PlayerType : BaseModel
    {
        private PlayerType(PlayerTypeEnum @enum)
        {
            Id = (int) @enum;
            Name = @enum.ToString();
            Description = @enum.GetDescription();
        }

        protected PlayerType() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override int Id { get; protected set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}