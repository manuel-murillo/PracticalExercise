using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Core.Entities;
using Travel.Core.Interfaces;
using Travel.SharedKernel;
using Travel.SharedKernel.Interfaces;

namespace Travel.Core.Services
{
    public class BookService : Service, IBookService
    {
        public BookService(IRepository repository) : base(repository) { }

        public IBookInformation GetBook(long isbn)
        {
            var book = Repository.GetById<Book>(b => b.Isbn == isbn, null, "Editorial", "Authors");

            return ParseBookInformation(book);
        }

        public async Task<IBookInformation> GetBookAsync(long isbn)
        {
            var book = await Repository.GetByIdAsync<Book>(b => b.Isbn == isbn, null, "Editorial", "Authors");

            return ParseBookInformation(book);
        }

        private BookInformation ParseBookInformation(Book book)
        {
            return new BookInformation
            {
                Title = book.Title,
                Synopsis = book.Synopsis,
                Pages = book.Pages,
                EditorialName = book.Editorial.Name,
                EditorialHeadquarters = book.Editorial.Headquarters,
                Authors = book.Authors
                    .OrderBy(a => a.LastName)
                    .Select(a => $"{a.FirstName} {a.LastName}")
                    .ToList()
            };
        }

        public IDictionary<long, string> GetBooks()
        {
            var books = Repository.GetCollection<Book>(orderBy: b => b.OrderBy(t => t.Title));

            return books.ToDictionary(b => b.Isbn, b => b.Title);
        }

        public async Task<IDictionary<long, string>> GetBooksAsync()
        {
            var books = await Repository.GetCollectionAsync<Book>(orderBy: b => b.OrderBy(t => t.Title));

            return books.ToDictionary(b => b.Isbn, b => b.Title);
        }
    }
}
