namespace C_sharp_exercises_2
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string BookData { get; set; }
        public Book(string name, string title, string BookDta)
        {
            this.Author = name;
            this.Title = title;
            this.BookData = BookDta;
        }
    }
}
