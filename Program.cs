using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "C# de ma";
            book.Author = "Pham Tan Dung";
            book.Year = 2003;
            Console.WriteLine(book.ToString());


            Magazine magazine = new Magazine();
            magazine.Title = "A cay oi";
            magazine.Author = "Alu";
            magazine.Year = 2000;
            Console.WriteLine(magazine.ToString());

            DVD dvd = new DVD();
            dvd.Title = "thien online";
            dvd.Author = "style";
            dvd.Year = 2021;
            Console.WriteLine(dvd.ToString());


            Console.ReadLine();
        }
    }
}