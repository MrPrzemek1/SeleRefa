using System.Collections.Generic;

namespace CSharp
{
    internal class BookRepository
    {
            public List<Book> GetBook()
            {
                return new List<Book>
                {
                    new Book() {Title="Dracula", Price=5},
                    new Book() {Title="Title 2", Price=1},
                    new Book() {Title="Hobbit", Price=3}
                };
            }
    }
}