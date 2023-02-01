using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Published_Year { get; set; }
        public string Author { get; set; }

        public Book()
        {

        }

        public Book(string title)
        {
            Title = title;
            Published_Year = $"Published year of {title}";
        }

        public Book(int id, string title, string published_year, string author)
        {  
            Id = id;
            Title = title;
            Published_Year = published_year;
            Author = author;

        }
        public override string ToString()
        {
            return $"Book: {Title}, Published Year:{Published_Year}, Author:{Author}" ;
        }



    }
}
