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
        private Author Author;
        private int Qty;
        public Book(string name, Author author, double price, int qty=0)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
            this.Qty = qty;
        }
        public string GetName()
        {
            return this.Name;
        }
        public Author GetAuthor()
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
        public void SetQty(int Qty){
            this.Qty = Qty;
        }
        public override string ToString()
        {
            return String.Format("Book[name= {0}, {1} ,[price= {2}, qty= {3}]", this.Name, this.Author, this.Price, this.Qty);
        }
        public String getAuthorName()
        {
            return Author.GetName();
            
        }
        public String getAuthorEmail()
        {
            return Author.GetEmail();
            
        }
        public char getAuthorGender()
        {
            return Author.GetGender();
            
        }
    }
}
