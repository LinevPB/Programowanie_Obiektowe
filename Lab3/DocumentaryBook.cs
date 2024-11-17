using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class DocumentaryBook : Book
    {
        public string DocumentaryDetails { get; set; }

        public DocumentaryBook(string title, Person author, DateTime publicationDate, string documentaryDetails)
            : base(title, author, publicationDate)
        {
            DocumentaryDetails = documentaryDetails;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Opis dokumentu: {DocumentaryDetails}");
        }
    }
}
