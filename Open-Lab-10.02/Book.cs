using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._02
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private string releaseDate;

        public Book()
        {

        }
        public string Title(string sTitle)
        {
            this.title = sTitle;
            return title;
        }
        public int Pages(int sPages)
        {
            this.pages = sPages;
            return pages;
        }
        public string Category(string sCategory)
        {
            this.category = sCategory;
            return category;
        }
        public string Author(string sAuthor)
        {
            this.author = sAuthor;
            return author;
        }
        public string ReleaseDate(string sReleaseDate)
        {
            this.releaseDate = sReleaseDate;
            return releaseDate;
        }
    public void VypisUdajov()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }
    }
}
