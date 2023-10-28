using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_E_Commerce
{
    internal class Customer
    {
        public Customer(int customerId, string? name, string? email)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
        }

        public int CustomerId {  get; set; }
        public string?Name { get; set; }
        public string? Email { get; set; }

        public static List<DigitalProduct> OrderDigitalProducts { get; set; }

        public static List<PhysicalProduct>OrderPhysicalProducts { get; set; }

        public static void AddToCart(int Id)
        {
            DigitalProduct Product=DigitalProduct.DigitalPRoductList.Find(x=>x.ProductId== Id);
            if(Product!=null)
            {
              Customer.OrderDigitalProducts.Add(Product);
            }
            PhysicalProduct physicalProduct=PhysicalProduct.physicalProductList.Find(x=>x.ProductId== Id);  
            if(physicalProduct!=null)
            {
                Customer.OrderPhysicalProducts.Add(physicalProduct);
            }
        }

    }
}
