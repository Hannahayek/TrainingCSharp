namespace Generics
{
    public class Book:Product
    {
        public string Isbn { get; set; }
      
        public Book(string isbn,string title)
        {
            this.Isbn = isbn;
            this.Title = title;
        }
    }
}