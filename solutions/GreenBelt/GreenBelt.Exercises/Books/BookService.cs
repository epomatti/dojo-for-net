using System;
using System.Collections.Generic;
using System.Linq;

namespace Books
{
  public class BookService
  {
    private BookContext _context;

    public BookService(BookContext context)
    {
      _context = context;
    }

    public Book Add(string name, string author)
    {
      var book = new Book
      {
        Name = name,
        Author = author,
        Reserved = false
      };
      _context.Books.Add(book);
      _context.SaveChanges();

      return book;
    }

    public IEnumerable<Book> Find(string term)
    {
      return _context.Books
          .Where(b => b.Name.Contains(term))
          .OrderBy(b => b.Name)
          .ToList();
    }

    public void Reserve(Guid id)
    {
      _context.Books
          .Where(b => b.Id == id)
          .ToList()
          .ForEach(b => b.Reserved = true);
    }
  }
}