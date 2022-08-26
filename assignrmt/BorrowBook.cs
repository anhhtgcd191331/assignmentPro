using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignrmt
{
    public class BorrowBook
    {
        private string id;
        private string idBook;
        private string nameBorrow;
        private string phone;
        private string idCard;
        private string dateBorrow;

        public BorrowBook(string id, string idBook, string nameBorrow, string phone, string idCard, string dateBorrow)
        {
            this.id = id;
            this.idBook = idBook;
            this.nameBorrow = nameBorrow;
            this.phone = phone;
            this.idCard = idCard;
            this.dateBorrow = dateBorrow;
        }
        public override string ToString()
        {
            return "ID Borrow: '" + this.id
                + "', ID Book: '" + this.idBook
                + "', Borrower's name : '" + this.nameBorrow
                + "', Phone: '" + this.phone
                + "',   ID Card: '" + this.idCard
                + "',   Date Borrow: '" + this.dateBorrow;
        }
    }
}
