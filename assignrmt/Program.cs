using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignrmt
{
    internal class Program
    {
        static FuntionClass funtionClass = new FuntionClass();
        public static void someBook()
        {
            funtionClass.addBook(new Book("BOOK1", "God Created the Integers", "Hawking, Stephen", "mathematics", "04/10/2005", 300000, 4));
            funtionClass.addBook(new Book("BOOK2", "Data Smart", "Foreman, John", "data_science", "04/11/2013", 400000, 10));
            funtionClass.addBook(new Book("BOOK3", "Orientalism", "Said, Edward", "mathematics", "04/10/2005", 300000, 2));
            funtionClass.addBook(new Book("BOOK4", "Drunkard's Walk, The", "Mlodinow, Leonard", "science", "04/10/2005", 300000, 1));
            funtionClass.addBook(new Book("BOOK5", "How to Think Like Sherlock Holmes", "Konnikova, Maria", "psychology", "04/10/2005", 300000, 3));
            funtionClass.addBook(new Book("BOOK6", "Slaughterhouse Five", "Vonnegut, Kurt", "fiction", "04/10/2005", 300000, 3));
        }
        static void Main(string[] args)
        {
            someBook();
            int choice = -1;
            while (choice !=0)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Display all book in library");
                Console.WriteLine("2. Add new book in library");
                Console.WriteLine("3. Update information of book in library");
                Console.WriteLine("4. Remove book in library");
                Console.WriteLine("5. Find book in library");
                Console.WriteLine("6. Borrow book");
                Console.WriteLine("7. Display information borro book");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice here: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        funtionClass.displayListBook();
                        break;
                    case 2:
                        addNewBook();
                        break;
                    case 3:
                        Console.Write("Enter id book: ");
                        string id = Console.ReadLine();
                        funtionClass.editBook(id);
                        break;
                    case 4:
                        Console.Write("Enter id book: ");
                        string idReomve = Console.ReadLine();
                        funtionClass.removeBook(idReomve);
                        break;
                    case 5:
                        Console.Write("Enter id book: ");
                        string idFind = Console.ReadLine();
                        funtionClass.findBook(idFind);
                        break;
                    case 6:
                        addNewBorrow();
                        break;
                    case 7:
                        funtionClass.dislayInforBorrowBook();
                        break;
                    case 0:
                        Console.WriteLine("You have successfully exited the program");
                        break;
                    default: 
                        Console.WriteLine("Enter choice again!!!");
                        break;
                }
            }
        }
        static void addNewBook()
        {
            Console.Write("Id book: ");
            string idBook = Console.ReadLine();
            Console.WriteLine("Name of Book: ");
            string nameBook = Console.ReadLine();
            Console.Write("Author of Book: ");
            string authorBook = Console.ReadLine();
            Console.Write("Catefory of Book: ");
            string category = Console.ReadLine();
            Console.Write("Publication Year of Book: ");
            string year = Console.ReadLine();
            Console.Write("Price Book: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quatity = int.Parse(Console.ReadLine());    
            Book book = new Book(idBook,nameBook,authorBook,category, year, price,quatity);
            funtionClass.addBook(book);
        }

        static void addNewBorrow()
        {
            Console.Write("Id: ");
            string id = Console.ReadLine();
            string idBook = funtionClass.checkIdBook();
            Console.Write("Borrower's name: ");
            string name = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("ID Card: ");
            string idCard = Console.ReadLine();
            Console.Write("Date Borrow: ");
            string date = Console.ReadLine();
            BorrowBook borrow = new BorrowBook(id, idBook, name, phone, idCard, date);
            funtionClass.addBorrowBook(borrow);
        }

     
    }
}
