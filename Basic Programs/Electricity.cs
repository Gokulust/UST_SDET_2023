using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Electricity
    {
        int consumerNumber, previousReading, currentReading;
        string? consumerName;

        public Electricity(int consumerNumber, int previousReading, int currentReading, string? consumerName)
        {
            this.consumerNumber = consumerNumber;
            this.previousReading = previousReading;
            this.currentReading = currentReading;
            this.consumerName = consumerName;
        }

        //public Electricity()
        //{
        //    consumerNumber = 12345;
        //    previousReading = 1000;
        //    currentReading = 1300;
        //    consumerName = "Gokul";
        //}
        public double CalculateBill()
        {
            double billAmount ;
            int reading = currentReading - previousReading;
            if(reading <=100)
            {
                billAmount = reading * 2.00;
            }
            else if(reading >=101 && reading <=200 )
            {
                billAmount = (100 * 2) + ((reading - 100) * 2.5);
            }
            else if(reading >=201 && reading<=400)
            {
                billAmount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
            }
            else 
            {
                billAmount = (100 * 2) + (100 * 2.5) + (200 * 3.5) + ((reading - 400) * 5.00);
            }
            return billAmount;
        }

    }
}
