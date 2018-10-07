using System;
using System.ComponentModel;

namespace ExchangeGame.Domain.Utils
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            return !(Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) 
                is DescriptionAttribute attribute) ? 
                value.ToString() : attribute.Description;
        }
    }
}