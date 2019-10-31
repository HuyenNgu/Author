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
            Author[] authors = new Author[2];
            authors[0] = new Author("HuyenNgu", "yurikawsaoki@gmail.com", 'F');
            
            authors[1] = new Author("ToxNgu", "Toxngu@gmail.com", 'F');
            Console.WriteLine(authors);

// Declare and allocate a Book instance
            Book javaDummy = new Book("Java for Dummy", authors, 19.99, 99);
            Console.WriteLine(javaDummy);  // toString()
        }
    }

}
