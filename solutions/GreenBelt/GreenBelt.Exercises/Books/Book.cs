using System;

namespace Books
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Boolean Reserved { get; set; }
    }
}