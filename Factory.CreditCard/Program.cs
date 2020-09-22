using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory cardFactory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string card = Console.ReadLine();

            switch (card.ToLower())
            {
                case "moneyback":
                    cardFactory = new MoneyBackFactory(50000, 0);
                    break;
                case "platinum":
                    cardFactory = new PlatinumFactory(100000, 500);
                    break;
                case "titanium":
                    cardFactory = new TitaniumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = cardFactory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();

        }
    }
}
