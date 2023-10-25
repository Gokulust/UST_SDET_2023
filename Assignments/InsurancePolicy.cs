using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class InsurancePolicy
    {
        public InsurancePolicy(string? policyName, int policyId, double premiumamount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            Premiumamount = premiumamount;
        }

        public string? PolicyName {  get; set; }
         public int PolicyId { get; set; }
         public double  Premiumamount { get; set; }

        public void RenewPolicy(double newPremium)
        {
            Premiumamount = newPremium;
        }
        public void RenewPolicy()
        {
            Premiumamount = Premiumamount * 1.1;
        }
        public void DisplayRenewdAmount()
        {
            Console.Write("Renewd Policy Premium Amount : {0} \n", Premiumamount);
        }



    }
}
