using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class libary
    {
        public string Title;
        public string Author;
        public int Year;

        public override string ToString()
        {
            return "Type: Library Item\nTitle: " + Title + "\nAuthor: " + Author + "\nYear: " + Year + "\n";
        }

    }
    public class Book : libary
    {
        public override string ToString()
        {
            return "Type: Book\nTitle: " + Title + "\nAuthor: " + Author + "\nYear: " + Year + "\n";
        }
    }
    public class Magazine : libary
    {
        public override string ToString()
        {
            return "Type: Magazine\nTitle: " + Title + "\nAuthor: " + Author + "\nYear: " + Year + "\n";
        }
    }

    public class DVD : libary
    {
        public override string ToString()
        {
            return "Type: DVD\nTitle: " + Title + "\nAuthor: " + Author + "\nYear: " + Year + "\n";
        }
    }

}
