using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CreditCard
{
    class PlatinumCreditCard : CreditCard
    {
        private string _cardType;

        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            this._cardType = "Platinum";
            this.CreditLimit = creditLimit;
            this.AnnualCharge = annualCharge;
        }

        public override string CardType
        {
            get { return _cardType; }
        }
    }
}
