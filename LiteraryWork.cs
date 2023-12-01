using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emir_mertoglu_homework_1
{
    public class LiteraryWork : IPrintable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public int BookID { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Book ID: {BookID}, Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}");
        }
    }
}
