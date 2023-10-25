using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal abstract class  InsurancePolicyAbstract
    {
        public string? PolicyName { get; set; }

        public int PolicyId { get; set; }

        public double PremiumAmount {  get; set; }

        public abstract double CalculatePermium();
    }
}
