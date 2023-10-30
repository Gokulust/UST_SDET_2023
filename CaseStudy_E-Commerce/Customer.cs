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

        public  List<DigitalProduct>CartDigitalProducts =new List<DigitalProduct>();

        public  List<PhysicalProduct>CartPhysicalProducts=new List<PhysicalProduct>();

        public List<PhysicalProduct> OrderedPhysicalProducts = new List<PhysicalProduct>();

        public  List<DigitalProduct> OrderedDigitalProducts = new List<DigitalProduct>();

        public static List<Customer>CustomerList =new List<Customer>();

        public  void AddToCart(int Id)
        {
            DigitalProduct Product=DigitalProduct.DigitalPRoductList.Find(x=>x.ProductId== Id);
           
            if(Product!=null)
            {
              CartDigitalProducts.Add(Product);
            }
            PhysicalProduct physicalProduct=PhysicalProduct.physicalProductList.Find(x=>x.ProductId== Id);  
            if(physicalProduct!=null)
            {
                CartPhysicalProducts.Add(physicalProduct);
            }
        }

    }
}
