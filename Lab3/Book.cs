using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Book
    {
        protected string Title { get; set; }
        protected Person Author { get; set; }
        protected DateTime PublicationDate { get; set; }

        public Book(string title, Person author, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
        }

        public string GetTitle
        {
            get { return Title; }
        }

        public virtual void View()
        {
            Console.WriteLine($"Tytuł: {Title}");
            Console.WriteLine($"Autor: {Author.FirstName} {Author.LastName}");
            Console.WriteLine($"Data wydania: {PublicationDate.ToShortDateString()}");
        }
    }
}
