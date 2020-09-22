using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CreditCard
{
    abstract class CreditCard
    {
        public abstract string CardType { get; }
        public int CreditLimit { get; set; }
        public int AnnualCharge { get; set; }
    }
}
