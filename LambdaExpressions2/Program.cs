using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //below without Lambda
            // var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            //findall methods takes function as delegate
            //books.FindAll();

            //to achieve same result with Lamda,we remove method IsCheaperThan10Dollars
            //and we write as beow
            var cheapBooks = books.FindAll(n => n.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }


            Console.ReadLine();
            



        }
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
