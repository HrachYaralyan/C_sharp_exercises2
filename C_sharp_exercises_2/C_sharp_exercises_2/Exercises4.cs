using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_exercises_2
{
    class Book
    {
        public string author;
        public string title;
        public DateTime BookDta;
        public Book(string name, string title, DateTime BookDta)
        {
            this.author = name;
            this.title = title;
            this.BookDta = BookDta;
        }
    }
    internal class Exercises4
    {
        public void libraryFilter()
        {
            IList<Book> bookList = new List<Book>() { };

            DateTime dt = DateTime.Now;

            var Book1 = new Book("Max", "ANgular", dt);
            var Book2 = new Book("Raffaello", "css", dt);
            var Book3 = new Book("Michelangelo", "js", dt);
            var Book4 = new Book("Doremi", "c++", dt);
            var Book5 = new Book("Fasollya", "react", dt);
            var Book6 = new Book("Max", "ANgular", dt);
            var Book7 = new Book("Samuel", "css", dt);
            var Book8 = new Book("Joe", "Alchimic", dt);
            var Book9 = new Book("Harry", "js", dt);
            var Book10 = new Book("Bob", "css", dt);

            bookList.Add(Book1);
            bookList.Add(Book2);
            bookList.Add(Book3);
            bookList.Add(Book4);
            bookList.Add(Book5);
            bookList.Add(Book6);
            bookList.Add(Book7);
            bookList.Add(Book8);
            bookList.Add(Book9);
            bookList.Add(Book10);

            var query =
                        from cust in bookList
                        where cust.title.Substring(0, 1).ToLower() == "a"
                        where bookList.Where(x => x.author == cust.author).Select(z => z).Count() > 1
                        select cust;


            var result = query.GroupBy(
                p => p.author,
                (key, g) => new { author = key });

            foreach (var item in result)
            {
                Console.WriteLine(item.author);
            }
        }
    }
}