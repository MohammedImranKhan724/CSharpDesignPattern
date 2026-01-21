using System;

namespace Factory.FactoryExampleTwo
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {

            ICreditCard creditCard = cardType switch
            {
                "MoneyBack" => new MoneyBack(),
                "Titanium" => new Titanium(),
                "Platinum" => new Platinum(),
                _ => throw new ArgumentException("Invalid card type"),
            };


            //ICreditCard creditCard = null;

            //switch (cardType)
            //{
            //    case "MoneyBack":
            //        creditCard = new MoneyBack();
            //        break;
            //    case "Titanium":
            //        creditCard = new Titanium();
            //        break;
            //    case "Platinum":
            //        creditCard = new Platinum();
            //        break;
            //    default:
            //        throw new ArgumentException("Invalid card type");
            //}
            return creditCard;

        }

    }
}
