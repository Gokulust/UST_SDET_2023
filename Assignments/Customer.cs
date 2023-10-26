using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }

        public int CustomerPhoneNumber { get; set; }
        public double CustomerBalance { get; set; }

        public static List<Customer> CustomerList = new List<Customer>();

        public Customer(int customerID, string? customerName, int customerPhoneNumber, double customerBalance)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            CustomerPhoneNumber = customerPhoneNumber;
            CustomerBalance = customerBalance;
        }
        public static void GetCustomerByPhoneNumber(int phoneNumber)
        {
            Customer customer=CustomerList.Find(x=>x.CustomerPhoneNumber == phoneNumber);
            if(customer != null)
            {
                Console.WriteLine("Customer Name: {0}\nCustomer Balance : {1}", customer.CustomerName, customer.CustomerBalance);
            }
            else
            {
                Console.WriteLine("Customer Not Found");
            }
        }
        public static void DisplayAllCustomer()
        {
            foreach(Customer customer in CustomerList)
            {
                Console.WriteLine("Customer Name : {0}\n customer PhoneNumber: {1}\nCustomer Balance: {2}", customer.CustomerName, customer.CustomerPhoneNumber, customer.CustomerBalance);
            }
        }
    }
}
