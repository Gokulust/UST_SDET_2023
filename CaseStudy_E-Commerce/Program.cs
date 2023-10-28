// See https://aka.ms/new-console-template for more information
using CaseStudy_E_Commerce;

int n = 0;
while(n==0)
{
    Console.WriteLine("1.Admin 2.User");
    int userType=Convert.ToInt32(Console.ReadLine());
    switch (userType)
    {
        case 1:
            Console.Write("1.Add Pysical Product");
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
                    product.Deight = weight;
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
                    Console.WriteLine("Enter the weight:");
                    string downloadLink = Console.ReadLine();
                    Console.WriteLine("Enter the dimension");
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

            }
            break;
        case 2:
            Console.WriteLine("Enter the use id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            string email = Console.ReadLine();
            Customer customer = new Customer(id, name, email);
            Console.WriteLine("1.Add Product to Cart by productid 2.Order Product 3.view Order 4.support");
            int chi = Convert.ToInt32(Console.ReadLine());
            switch (chi)
            {
                case 1:
                    Console.WriteLine("Physcial Products With Id");
                    foreach (var pProduct in PhysicalProduct.physicalProductList)
                    {
                        Console.WriteLine("Product Name:{0} Product Id:{1}", pProduct.ProductName, pProduct.ProductId);
                    }
                    Console.WriteLine("Digital Products With Id");
                    foreach (var dProduct in DigitalProduct.DigitalPRoductList)
                    {
                        Console.WriteLine("Product Name:{0} Product Id:{1}", dProduct.ProductName, dProduct.ProductId);

                    }
                    Console.WriteLine("Enter the Product Id");
                    int pid = Convert.ToInt32(Console.ReadLine());
                    Customer.AddToCart(pid);
                    break;
                case 2:Console.WriteLine("Order Placed Successfully");
                    break;


            }
            break;

    }

    }