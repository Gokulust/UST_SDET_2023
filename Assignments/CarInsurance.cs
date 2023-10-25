using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance:InsurancePolicyAbstract
    {
        public string? CustomerName {  get; set; }
        public string? VehicleType { get; set; }
        public int KilometerUsed { get; set; }

        public override double CalculatePermium()
        {
            if(KilometerUsed>100000)
            {
                PremiumAmount = PremiumAmount * 1.1;
                return PremiumAmount;
            }
            else
            {
                PremiumAmount = PremiumAmount * 1.2;
                return PremiumAmount;
            }
        }
    }
}
