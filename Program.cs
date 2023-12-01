using emir_mertoglu_homework_1.Services;
using System;

namespace emir_mertoglu_homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryService libraryService = new LibraryService();

            Book book1 = new Book("Harry Potter", "J.K. Rowling", 2001, 1);
            Book book2 = new Book("Sherlock Holmes", "Arthur Conan Doyle", 1892, 2);


            Member member1 = new Member("Walter", "White", 101);
            Member member2 = new Member("Jesse", "Pinkman", 102);

            libraryService.AddBook(book1);
            libraryService.AddBook(book2);

            libraryService.AddMember(member1);
            libraryService.AddMember(member2);

            libraryService.BorrowBook(member1, book1);
            libraryService.BorrowBook(member2, book2);

            

            Console.WriteLine("\nBooks:");


            foreach (var book in libraryService.books)
            {
                book.Print();
            }

            Console.WriteLine("\nMembers:");
            foreach (var member in libraryService.members)
            {
                member.Print();
            }
        }
    }
}
