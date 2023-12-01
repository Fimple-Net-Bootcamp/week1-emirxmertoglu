using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emir_mertoglu_homework_1
{
    public class Book : LiteraryWork
    {
        public Book(string title, string author, int publicationYear, int bookID)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            BookID = bookID;
        }
     
    }
}
