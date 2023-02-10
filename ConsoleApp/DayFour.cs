using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp
{
    public static class DayFour
    {
        /// <summary>
        /// Create a book and print it in console
        /// </summary>
        public static void ProgramOne()
        {
            Book book = new Book
            {
                Id = 1,
                Title = "Test Book",
                Author = "Test Author",
                Published_Year = "2009",
            };
            Console.WriteLine("Program One");
            Console.WriteLine($"Book: {book.Title} || By:{book.Author} || Published On:{book.Published_Year} \n");
        }
        /// <summary>
        /// Create a list of book and print it in console
        /// </summary>
        public static void ProgramTwo()
        {
            List<Book> Books = new List<Book>();
            Books.Add(new Book { Id = 1, Title = "Book one", Author = "Author one", Published_Year = "2000" });
            Books.Add(new Book { Id = 2, Title = "Book two", Author = "Author two", Published_Year = "2010" });
            Books.Add(new Book { Id = 3, Title = "Book three", Author = "Author three", Published_Year = "2020" });
            Console.WriteLine("Program Two");
            Console.WriteLine($"No. of books: {Books.Count}");
            foreach (var Book in Books)
            {
                Console.WriteLine($"Book: {Book.Title} || By:{Book.Author} || Published On:{Book.Published_Year}");
            }
        }
        public static void ProgramThree()
        {
            List<Book> Books  = new List<Book>();
            Books.AddRange(new Book[]
            {
                new Book { Id = 1, Title = "Book one", Author = "Author one", Published_Year = "2000" },
                new Book { Id = 2, Title = "Book two", Author = "Author two", Published_Year = "2010" },
                new Book { Id = 3, Title = "Book three", Author = "Author three", Published_Year = "2015" },
                new Book { Id = 4, Title = "Book four", Author = "Author four", Published_Year = "2016" },
                new Book { Id = 5, Title = "Book five", Author = "Author five", Published_Year = "2020" },
                new Book { Id = 6, Title = "Book six", Author = "Author six", Published_Year = "2022" },
            });
            Console.WriteLine();
            Console.WriteLine("Program Three");
            Console.WriteLine($"No. of books: {Books.Count}");

            foreach (var book in Books)
            {
                Console.WriteLine($"Book: {book.Title} || By:{book.Author} || Published On:{book.Published_Year}");
            }
            Console.WriteLine();
            //select * FROM Book;
            var bookQuery = from book in Books.AsQueryable() select book;

            //select * FROM Book WHERE ID NOT IN (4,5);
            var selectedBook = bookQuery.Where(Book => !new int[] { 4, 5 }.Contains(Book.Id))
                .ToList();

            Console.WriteLine("Books where id is not {4,5}:");
            foreach (var book in selectedBook)
            {
                Console.WriteLine($"Book: {book.Title} || By:{book.Author} || Published On:{book.Published_Year}");
            }

            //SELECT emp.Id, emp.Name,emp.Email,des.DesignationName,emp.Salary FROM employees as emp JOIN designation AS des ON emp.DesignationId = des.ID ;

           /* public static void Linqstatement()
            {
                //SELECT StudentName, Age, COUNT(Age) As AgeCount FROM Student WHERE StudentName = 'Aakash' GROUP BY StudentName, Age HAVING COUNT(Age) > 1;

                var linqquery = (from student in students where student.studentName == "Aakash"
                                 group student by new { student.studentName, student.Age } into studentGroup
                                 where studentGroup.Count() > 1
                                 select new
                                 {
                                     studentName = studentGroup.key.studentName,
                                     Age = studentGroup.key.Age,
                                     AgeCount = studentGroup.Count()
                                 }).ToList();

            }*/

        }


    }
}


