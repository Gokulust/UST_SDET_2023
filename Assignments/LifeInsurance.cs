using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance:InsurancePolicyAbstract
    {
        public LifeInsurance(string? customerName, int customerAge)
        {
            CustomerName = customerName;
            CustomerAge = customerAge;
        }

        public string? CustomerName { get; set; }

        public int CustomerAge { get; set; }

        public override double CalculatePermium()
        {
            if(CustomerAge<60)
            {
                PremiumAmount = PremiumAmount * 1.2;
                return PremiumAmount;
            }
            else
            {
                PremiumAmount = PremiumAmount * 1.1;
                return PremiumAmount;
            }

        }
    }
}
