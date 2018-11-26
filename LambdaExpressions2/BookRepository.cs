using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions2
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title="title 1",Price=15},
                new Book(){Title="title 2",Price=7},
                new Book(){Title="title 3",Price=13}
            };
        }  
  
    }
}
