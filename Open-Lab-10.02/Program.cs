using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title("Lord of the Rings");
            LOTR.Pages(576);
            LOTR.Category("Fantasy");
            LOTR.Author("J.R.R.Tolkien");
            LOTR.ReleaseDate("29.7.1954");
            LOTR.VypisUdajov();
        }
    }
}
