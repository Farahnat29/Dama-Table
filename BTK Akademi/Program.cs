using System;

namespace BTK_Akademi
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();
            car.Audi();
            car.Mercides();

            Laptopscs laptopscs = new Laptopscs();
            laptopscs.Asus();
            laptopscs.lenovo();

            Customer customer = new Customer
            {
                City = "new york",
                id = 1234567,
                FirstName = "Joseph",
                LastName = "george"
            };

            Customer customer1 = new Customer
            {
                FirstName = "ahmet", LastName="mohammed", id=25, City="Amman"
                

            };
            Console.WriteLine(customer.City);
            Console.WriteLine(customer1.id);
        }
    }
    
}
