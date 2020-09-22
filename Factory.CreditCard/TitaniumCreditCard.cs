using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CreditCard
{
    class TitaniumCreditCard : CreditCard
    {
        private string _cardType;

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            this._cardType = "Titanium";
            this.CreditLimit = creditLimit;
            this.AnnualCharge = annualCharge;
        }
        public override string CardType
        {
            get { return _cardType; }
        }
    }
}
