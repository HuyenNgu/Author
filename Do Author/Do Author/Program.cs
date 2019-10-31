using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_Author
{
    class Program
    {
        static void Main(string[] args)
        {
            Author ahTeck1 = new Author("HuyenNGU", "ahteck@nowhere.com", 'f'); // Test the constructor
            Console.WriteLine(ahTeck1);  // Test toString()
            ahTeck1.SetEmail("yurikawsaoki@gmail");  // Test setter
            Console.WriteLine("name is: " + ahTeck1.GetName());     // Test getter
            Console.WriteLine("eamil is: " + ahTeck1.GetEmail());   // Test getter
            Console.WriteLine("gender is: " + ahTeck1.GetGender());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Author ahTeck = new Author("HuyenNgu", "yurikawsaoki@gmail.com", 'F');
            Console.WriteLine(ahTeck);  // Author's toString()

            Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
            Console.WriteLine(dummyBook);  // Test Book's toString()

            // Test Getters and Setters
            dummyBook.setPrice(29.95);
            dummyBook.SetQty(28);
            Console.WriteLine("name is: " + dummyBook.GetName());
            Console.WriteLine("price is: " + dummyBook.GetPrice());
            Console.WriteLine("qty is: " + dummyBook.GetQty());
            Console.WriteLine("Author is: " + dummyBook.GetAuthor());  // Author's toString()
            Console.WriteLine("Author's name is: " + dummyBook.GetAuthor().GetName());
            Console.WriteLine("Author's email is: " + dummyBook.GetAuthor().GetEmail());

// Use an anonymous instance of Author to construct a Book instance
            Book anotherBook = new Book("more Java", 
            new Author("HuyenSuperNgu", "Huyengu@gmail.com", 'F'), 29.95);
            Console.WriteLine(anotherBook);  // toString()
        }
    }
}
