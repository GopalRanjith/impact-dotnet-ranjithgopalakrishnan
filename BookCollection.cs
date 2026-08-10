using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLearning
{
    public class BookCollection : IEnumerable<Book>
    {
        private List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in books.OrderBy(b => b.Title))
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}