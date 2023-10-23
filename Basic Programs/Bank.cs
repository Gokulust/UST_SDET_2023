using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Bank
    {
        //public Bank() 
        //{ 
        //    CustomerId= 111111;
        //    AccountNumber = 908775L;
        //    Name = "Vishnu";
        //    Status = "Active";
        //}
        //public Bank(int customerId, long accountNumber, string? name)
        //{
        //    CustomerId = customerId;
        //    AccountNumber = accountNumber;
        //    Name = name;
        //    Status = "InActive";
        //}

        public Bank(int customerId, long accountNumber, string? name, string? status)
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            Name = name;
            Status = status;
        }

        public int CustomerId { get; set; }

        public long AccountNumber { get; set; }

        public string? Name { get; set; }

        public string? Status { get; set; }

        public virtual void WelcomeMessage()
        {
            Console.WriteLine("Welcome");
        }

        public void GetAccountDetails(int customerId)
        {
            if (customerId==CustomerId) {
                Console.WriteLine("Account No:{0} \t Name: {1} Status : {2}", AccountNumber, Name, Status);
            }
            else
            {
                Console.WriteLine("Customer Id does not exist");
            }
        }

        public void GetAccountDetails(long accountNumber)
        {
            if (accountNumber == AccountNumber)
            {
                Console.WriteLine("Customer Id:{0} \t Name: {1} Status : {2}", CustomerId, Name, Status);
            }
            else
            {
                Console.WriteLine("Account Number does not exist");
            }
        }

        public void GetAccountDetails(string name)
        {
            if (name == Name)
            {
                Console.WriteLine("Account No:{0} \t Name: {1} Status : {2}", AccountNumber, Name, Status);
            }
            else
            {
                Console.WriteLine("Name does not exist");
            }
        }

    }
}
