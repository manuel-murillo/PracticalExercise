using System.Collections.Generic;
using System.Threading.Tasks;

namespace Travel.Core.Interfaces
{
    public interface IBookService
    {
        IBookInformation GetBook(long isbn);

        Task<IBookInformation> GetBookAsync(long isbn);

        IDictionary<long, string> GetBooks();

        Task<IDictionary<long, string>> GetBooksAsync();
    }
}
