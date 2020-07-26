using ASPNETCoreDISample.Contracts;
using ASPNETCoreDISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreDISample.Repositories
{
    public class InMemoryBooksRepository : IBooksRepository
    {
        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();

            books.Add(new Book { ID = 1, ISBN = "Test ISBN 1", Name = "Test Book 1" });
            books.Add(new Book { ID = 1, ISBN = "Test ISBN 1", Name = "Test Book 1" });
            books.Add(new Book { ID = 1, ISBN = "Test ISBN 1", Name = "Test Book 1" });

            return books;
        }
    }
}
