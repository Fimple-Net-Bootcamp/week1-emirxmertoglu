using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emir_mertoglu_homework_1
{
    public class Member : IPrintable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MembershipNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(string firstName, string lastName, int membershipNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            MembershipNumber = membershipNumber;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
            Console.WriteLine($"{FirstName} {LastName} borrowed the book: {book.Title}.");

        }

        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
            Console.WriteLine($"{FirstName} {LastName} returned the book: {book.Title}.");
        }

        public void Print()
        {
            Console.WriteLine($"Member Information - First Name: {FirstName}, Last Name: {LastName}, Membership Number: {MembershipNumber}");
        }
    }
}
