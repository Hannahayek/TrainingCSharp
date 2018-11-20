namespace Generics
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public Book(string isbn,string title)
        {
            this.Isbn = isbn;
            this.Title = title;
        }
    }
}