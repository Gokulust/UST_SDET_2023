// See https://aka.ms/new-console-template for more information

using CaseStudy;
int k = 1;
int n=1;
int i = 0;
Genre[] bookArray = new Genre[10];
Order order = new Order();
while (n == 1)
{
    Console.WriteLine("Select the option:");
    Console.WriteLine("1.Add New Book \n2.Search Book \n3.Add customer \n4.Buy Book \n5.Display Order Details");
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            
            AddBook();
            break;
        case 2:
            SearchBook();
            break;
        case 3:
            AddCustomer();
            break;
        case 4:
            BuyBook();
            break;
        case 5:
            DisplayOrderDetails();
            break;
    }
    Console.WriteLine("press 1 enter to continue");
    n=Convert.ToInt32(Console.ReadLine());
}

 void AddBook()
{
 
 
    Console.WriteLine("Enter the Book Title:");
    string title=Console.ReadLine();
    Console.WriteLine("Enter the author Name:");
    string author = Console.ReadLine();
    Console.WriteLine("Enter the ISBM:");
    int ISBM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the price :");
    int price=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the availability");
    string availability=Console.ReadLine();
    Console.WriteLine("Enter the Book Type");
    string bookType=Console.ReadLine();
    Genre book =new Genre(title,author,ISBM,price,availability,bookType);
    bookArray[i] = book;
    Console.WriteLine(bookArray[i].ISBN);
    i++;
}
void SearchBook()
{
    Console.WriteLine("Enter the book id:");
    int bookId=Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < 10; i++)
    {
        if (bookArray[i] == null)
        {
            
                Console.Write("Book Not Found");

        }
        else if((bookId == bookArray[i].ISBN))
        {
            Console.WriteLine("Book Title: {0} Author : {1} price : {2} availabilty:{3} bookType: {4}", bookArray[i].Title, bookArray[i].Author, bookArray[i].Price, bookArray[i].Availability, bookArray[i].Type);
            break;
        }
    }
}

void AddCustomer()
{
    Customer customer = new Customer();
    Console.WriteLine("Enter the customer Id");
    customer.CustomerId=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter the Customer Name");
    customer.CustomerName=Console.ReadLine();
    Console.WriteLine("Enter the contact details");
    customer.ContactDetails=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Customer id : {0} \n Customer Name : {1} \nCustomer Mobile:{2}", customer.CustomerId, customer.CustomerName, customer.ContactDetails);
}
void BuyBook()
{
    
    while (k == 1)
    {
        Console.WriteLine("Enter the book id:");
        int bookId = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 10; i++)
        {
            if (bookArray[i] == null)
            {

                Console.Write("Book Not Found");
                break;

            }
            else if ((bookId == bookArray[i].ISBN))
            {
               
                Console.Write("Enter the order date:");
                order.OrderDate = Console.ReadLine();
                Order.OrderedBookList.Add(bookArray[i]);
                Console.WriteLine("Order Confirm Successfully");
                Console.WriteLine("Press 3 to continue purchase");
                k = Convert.ToInt32(Console.ReadLine());
                break;
                
            }
        }
    }
    

}
void DisplayOrderDetails()
{
    Console.WriteLine("ordered books");
    foreach (var book in Order.OrderedBookList)
    {
        Console.WriteLine(book.Title);
    }
    Console.WriteLine("Order Date:{0} Total Cost:{1}", order.OrderDate, order.GetTotalCost());
}
