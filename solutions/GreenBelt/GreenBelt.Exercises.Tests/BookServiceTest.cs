using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Books
{
    public class BookServiceTest
    {
        [Fact]
        public void Add_writes_to_database()
        {
            var options = new DbContextOptionsBuilder<BookContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;

            using (var context = new BookContext(options))
            {
                var service = new BookService(context);
                service.Add("Clean Code", "Robert C. Martin");
                service.Add("The Mythical Man-Month", "Fred Brooks");
                service.Add("Design Patterns", "GoF");
                context.SaveChanges();
            }

            using (var context = new BookContext(options))
            {
                Assert.Equal(3, context.Books.Count());
            }
        }

        [Fact]
        public void Find_searches_name()
        {
            var options = new DbContextOptionsBuilder<BookContext>()
                .UseInMemoryDatabase(databaseName: "Find_searches_name")
                .Options;

            using (var context = new BookContext(options))
            {
                context.Books.Add(new Book { Name = "Clean Code" });
                context.Books.Add(new Book { Name = "Domain Driven Design" });
                context.Books.Add(new Book { Name = "Test Driven Design" });
                context.SaveChanges();
            }

            using (var context = new BookContext(options))
            {
                var service = new BookService(context);
                var result = service.Find("Clean Code");
                Assert.Single(result);
            }
        }

        [Fact]
        public void Reserve_updates_to_database()
        {
            Assert.True(false, "Test is not implemented");
        }
    }
}
