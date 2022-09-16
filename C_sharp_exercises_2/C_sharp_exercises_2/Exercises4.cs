using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//Exercise 4:
//Create a class Book which should have author, title and createdDate properties.
//Create 10 instances of Book class.
//1.Filter latest 5 created Books.
//2. Group the books which authors are same person
//3. Find Books which title starts with A letter
namespace C_sharp_exercises_2
{
    internal class Exercises4
    {
        public string RetD()
        {
            var dt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff",
                                            CultureInfo.InvariantCulture);
            return dt;
        }
        public void filteringtoNameAndTitle()
        {
            var bookList = new List<Book>() { };
            DateTime dt = DateTime.Now;

            bookList.Add(new Book("Max", "ANgular", RetD()));
            bookList.Add(new Book("Raffaello", "css", RetD()));
            bookList.Add(new Book("Michelangelo", "js", RetD()));
            bookList.Add(new Book("Doremi", "c++", RetD()));
            bookList.Add(new Book("Fasollya", "react", RetD()));
            bookList.Add(new Book("Max", "ANgular", RetD()));
            bookList.Add(new Book("Samuel", "css", RetD()));
            bookList.Add(new Book("Joe", "Alchimic", RetD()));
            bookList.Add(new Book("Harry", "js", RetD()));
            bookList.Add(new Book("Bob", "css", RetD()));

            for (int i = 0; i < bookList.Count; i++)
            {
                Console.WriteLine(bookList[i].BookData);
            }
            var query =
                        from book in bookList
                        where book.Title.Substring(0, 1).ToLower() == "a"
                        where bookList.Where(x => x.Author == book.Author).Select(z => z).Count() > 1
                        select book;
            var result = query.GroupBy(
                p => p.Author,
                (key, index) => new { author = key });
            foreach (var item in result)
            {
                Console.WriteLine(item.author);
            }
        }
    }
}
