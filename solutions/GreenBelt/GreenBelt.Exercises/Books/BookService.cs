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

        public void Add(string name)
        {
            var blog = new Book
            {
                Id = Guid.NewGuid(),
                Name = name,
                Reserved = false
            };
            _context.Books.Add(blog);
            _context.SaveChanges();
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
                .ToList().ForEach(b => b.Reserved = true);
        }
    }
}