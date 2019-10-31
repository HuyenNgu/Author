using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_Author
{
    class Book
    {
        private string Name;
        private double Price;
        private Author[] Author;
        private int Qty;
        public Book(string name, Author [] authors, double price, int qty = 0)
        {
            this.Name = name;
            this.Author = authors;
            this.Price = price;
            this.Qty = qty;
        }
        public string GetName()
        {
            return this.Name;
        }
        public Author[] GetAuthor()
        {
            return this.Author;
        }
        public double GetPrice()
        {
            return this.Price;
        }
        public int GetQty()
        {
            return this.Qty;
        }
        public void setPrice(double Price)
        {
            this.Price = Price;
        }
        public void SetQty(int Qty)
        {
            this.Qty = Qty;
        }
        public override string ToString()
        {
            string[] strAuthors = new string[this.Author.Length];
            for (int i = 0; i < this.Author.Length; i++)
            {
                strAuthors[i] = this.Author[i].ToString();
            }
                return String.Format("Book[name= {0}, authors={{{1}}} ,[price= {2}, qty= {3}]", this.Name, String.Join(", ",strAuthors), this.Price, this.Qty);
        }
        public string GetAuthorNames()
        {
            string[] strAuthorsNames = new string[this.Author.Length];
            for (int i = 0; i< this.Author.Length; i++)
            {
                strAuthorsNames[i] = this.Author[i].GetName();
            }
                Console.WriteLine("");
                return String.Join(", ", strAuthorsNames);

        }

    }
}
