using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emir_mertoglu_homework_1.Services
{
    public class LibraryService
    {
        public List<Book> books;
        public List<Member> members;

        public LibraryService()
        {
            books = new List<Book>();
            members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} added to the library.");
        }
       

        public void RemoveBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine($"{book.Title} removed from the library.");
        }

        public void AddMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"{member.FirstName} {member.LastName} added to the library members.");
        }

        public void RemoveMember(Member member)
        {
            members.Remove(member);
            Console.WriteLine($"{member.FirstName} {member.LastName} removed from the library members.");
        }

        public void BorrowBook(Member member, Book book)
        {
            member.BorrowBook(book);
            Console.WriteLine($"{book.Title} borrowed by {member.FirstName} {member.LastName}.");
        }

        public void ReturnBook(Member member, Book book)
        {
            member.ReturnBook(book);
            Console.WriteLine($"{book.Title} returned by {member.FirstName} {member.LastName}.");
        }
    }
}
