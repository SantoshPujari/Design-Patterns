using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CreditCard
{
    class MoneyBackCreditCard : CreditCard
    {
        private string _cardType;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            this.CreditLimit = creditLimit;
            this.AnnualCharge = annualCharge;
        }

        public override string CardType
        {
            get { return _cardType; }
        }
    }
}
