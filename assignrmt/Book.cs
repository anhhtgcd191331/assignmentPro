using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignrmt
{
    public class Book
    {
        private string idBook;
        private string nameBook;
        private string authorBook;
        private string categoryBook;
        private string publicationYear;
        private double priceBook;
        private int quantity;

        public Book() { }

        public Book(string idBook, string nameBook, string authorBook, string categoryBook,string publicationYear, double priceBook, int quantity)
        {
            this.idBook = idBook;
            this.nameBook = nameBook;
            this.authorBook = authorBook;
            this.categoryBook = categoryBook;
            this.publicationYear = publicationYear;
            this.priceBook = priceBook;
            this.quantity = quantity;
        }
        public void setIdBook(string idBook)
        {
            this.idBook = idBook;
        }
        public string getIdBook()
        {
            return idBook;
        }
        public void setNameBook(string nameBook)
        {
            this.nameBook = nameBook;
        }
        public string getNameBook()
        {
            return nameBook;
        }
        public void setAuthorBook(string authorBook)
        {
            this.authorBook = authorBook;
        }
        public string getAuthorBook()
        {
            return authorBook;
        }
        public void setCategoryBook(string categoryBook)
        {
            this.categoryBook = categoryBook;
        }
        public string getCategoryBook()
        {
            return categoryBook;
        }
        public void setPublicationYear(string publicationYear)
        {
            this.publicationYear = publicationYear;
        }
        public string getpublicationYear()
        {
            return publicationYear;
        }
        public void setPriceBook(double priceBook)
        {
            this.priceBook = priceBook;
        }    
        public double getPriceBook()
        {
            return priceBook;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getQuatity()
        {
            return quantity;
        }
        public override string ToString()
        {
            return "ID Book: '" + this.idBook 
                + "', Name Book: '" + this.nameBook
                + "', Author Book: '" + this.authorBook
                + "', Category Book: '" + this.categoryBook
                + "', Price Book: '" + this.priceBook
                + "', Quantity Book: '" + this.quantity;
        }
    }
}
