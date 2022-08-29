using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignrmt
{
    public class FuntionClass
    {
        private static List<Book> books = new List<Book>();
        private static List<BorrowBook> borrowBooks = new List<BorrowBook>();
        
        public void displayListBook()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
        public void addBook(Book book)
        {
            books.Add(book);
        }
        public void editBook(string id)
        {
            foreach (Book book in books)
            {
                if (book.getIdBook().Equals(id))
                {
                    Console.Write("Name of Book: ");
                    string nameBook = Console.ReadLine();
                    Console.Write("Author of Book: ");
                    string authorBook = Console.ReadLine();
                    Console.Write("Catefory of Book: ");
                    string category = Console.ReadLine();
                    Console.Write("Price Book: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Quantity: ");
                    int quatity = int.Parse(Console.ReadLine());
                    book.setNameBook(nameBook);
                    book.setAuthorBook(authorBook);
                    book.setCategoryBook(category);
                    book.setPriceBook(price);
                    book.setQuantity(quatity);
                }
            }
        }
        public void removeBook(string id)
        {
            foreach(Book book in books)
            {
                if (book.getIdBook().Equals(id))
                {
                    books.Remove(book);
                    break;
                }
            }
        }

        public void findBook(string info)
        {
            foreach (Book book in books)
            {
                if (book.getIdBook().Equals(info)|| book.getNameBook().Equals(info)||book.getpublicationYear().Equals(info)||book.getCategoryBook().Equals(info))
                {
                    Console.Write(book.ToString());
                }
            }
        }

        public void dislayInforBorrowBook()
        {
            foreach(BorrowBook borrow in borrowBooks)
            {
                Console.WriteLine(borrow.ToString());
            }
        }
        public void addBorrowBook(BorrowBook borrow)
        {
            borrowBooks.Add(borrow);    
        }
        public string checkIdBook()
        {
            while (true)
            {
                Console.Write("ID Book: ");
                string idBook = Console.ReadLine();
                foreach (Book book in books)
                {
                    if (book.getIdBook().Equals(idBook) && book.getQuatity()!=0)
                    {
                        book.setQuantity(book.getQuatity() - 1);
                        return idBook;
                    }
                    else
                    {
                        Console.WriteLine("ID Book not found in library.");
                        Console.WriteLine("Please enter id book againt!!!!");
                    }
                }
            }
        }

    }
}
