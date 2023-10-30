// See https://aka.ms/new-console-template for more information
using CaseStudy_E_Commerce;

int n = 0;
while(n==0)
{
    Console.WriteLine("Enter the User Type");
    Console.WriteLine("1.Admin \n2.User");
    int userType=Convert.ToInt32(Console.ReadLine());
    switch (userType)
    {
        case 1:
            Console.WriteLine("1.Add Pysical Product \n2.Add Digital Product \n3.View Report");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the product id:");
                    int pdId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Product Name:");
                    string pName = Console.ReadLine();
                    Console.WriteLine("Enter the Price");
                    double Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Quantity");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the weight:");
                    int weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the dimension");
                    string dimension = Console.ReadLine();
                    PhysicalProduct product = new PhysicalProduct();
                    product.ProductId = pdId;
                    product.ProductName = pName;
                    product.ProductPrice = Price;
                    product.StockQuantity = quantity;
                    product.Dimension = dimension;
                    product.weight = weight;
                    PhysicalProduct.physicalProductList.Add(product);
                    break;
                case 2:
                    Console.WriteLine("Enter the product id:");
                    int dId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Product Name:");
                    string dName = Console.ReadLine();
                    Console.WriteLine("Enter the Price");
                    double dPrice = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Quantity");
                    int dQuantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Link:");
                    string downloadLink = Console.ReadLine();
                    Console.WriteLine("Enter the FileFormat");
                    string fileFormat = Console.ReadLine();
                    DigitalProduct dproduct = new DigitalProduct();
                    dproduct.ProductId = dId;
                    dproduct.ProductName = dName;
                    dproduct.ProductPrice = dPrice;
                    dproduct.StockQuantity = dQuantity;
                    dproduct.DownloadLink = downloadLink;
                    dproduct.FileFormat = fileFormat;
                    DigitalProduct.DigitalPRoductList.Add(dproduct);
                    break;
                case 3:foreach(var cust in Customer.CustomerList)
                    {
                        Console.WriteLine("Customer Name : {0}", cust.Name);
                        Console.WriteLine("Physical Products :");
                        foreach(var pro in cust.OrderedPhysicalProducts )
                        {
                            Console.WriteLine("product Name: {0}",pro.ProductName);
                        }
                        Console.WriteLine("Digital Products :");
                        foreach (var dpro in cust.OrderedDigitalProducts)
                        {
                            Console.WriteLine("Product Name: {0}",dpro.ProductName);
                        }

                    }
                    break;

            }
            break;
        case 2:
            Console.WriteLine("1.Existing User \n2.New User");
            int user=Convert.ToInt32(Console.ReadLine());
            Customer customer;
            if(user==1)
            {
                Console.WriteLine("Enter the user id:");
                int id = Convert.ToInt32(Console.ReadLine());
                customer=Customer.CustomerList.Find(x=>x.CustomerId==id);
                
            }
            else
            {
                Console.WriteLine("Enter the user id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Email");
                string email = Console.ReadLine();
                customer = new Customer(id, name, email);
                Customer.CustomerList.Add(customer);
            }
           
           
            int k = 0;
            while(k!=5)
            {
                Console.WriteLine("1.Add Product to Cart by productid \n2.Place Order \n3.view Order \n4.support \n5.Exit");
                int chi = Convert.ToInt32(Console.ReadLine());
                switch (chi)
                {
                    case 1:
                        Console.WriteLine("Products With Id");
                        foreach (var pProduct in PhysicalProduct.physicalProductList)
                        {
                            Console.WriteLine("Product Name:{0} Product Id:{1}", pProduct.ProductName, pProduct.ProductId);
                        }
                        foreach (var dProduct in DigitalProduct.DigitalPRoductList)
                        {
                            Console.WriteLine("Product Name:{0} Product Id:{1}", dProduct.ProductName, dProduct.ProductId);

                        }
                        Console.WriteLine("Enter the Product Id");
                        int pid = Convert.ToInt32(Console.ReadLine());
                        customer.AddToCart(pid);
                        break;
                    case 2:
                        double physicalProductTotalCost = PhysicalProduct.CalculateCost(PhysicalProduct.physicalProductList);
                        double digitalProductTotalCost = DigitalProduct.CalculateCost(DigitalProduct.DigitalPRoductList);
                        Console.WriteLine("Total Cost For Physical Products: {0} Total Cost For digital Product: {1}", physicalProductTotalCost, digitalProductTotalCost);
                        
                        customer.OrderedPhysicalProducts.AddRange(customer.CartPhysicalProducts);
                        customer.OrderedDigitalProducts.AddRange(customer.CartDigitalProducts);
                        customer.CartPhysicalProducts.Clear();
                        customer.CartDigitalProducts.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Physical Products");
                        foreach (var pProduct in customer.OrderedPhysicalProducts)
                        {
                            Console.WriteLine(pProduct.ProductName + "\n");
                        }
                        foreach (var dProduct in customer.OrderedDigitalProducts)
                        {
                            Console.WriteLine(dProduct.ProductName + "\n");
                        }
                        break;
                    case 4:Console.WriteLine("8976546");
                        break;
                        case 5:k = 5;
                        break;


                }

            }
            
            break;

    }

    }