using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book ("1111", "Csharp advances");
            //var numbers=new List();
            //numbers.Add(10);

            //var books=new BookList();
            //books.Add(book);
            var numbers=new GenericList<int>();
            numbers.Add(10);
            //here instead of we keep creating objects, we can pass any type of objects
            var books=new GenericList<Book>();
            books.Add(new Book("1111", "Csharp advances"));


        }
    }
}
