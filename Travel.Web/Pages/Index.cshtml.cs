using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Travel.Core.Interfaces;

namespace Travel.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBookService _bookService;

        public IndexModel(ILogger<IndexModel> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        public ICollection<SelectListItem> Books { get; set; }

        [BindProperty]
        [Display(Name = "BooksDisplayName", ResourceType = typeof(Index))]
        public long BookIsbn { get; set; }

        public IBookInformation Book { get; set; }

        private async Task SetBookModelAsync()
        {
            Book = await _bookService.GetBookAsync(BookIsbn);
        }

        public async Task<IActionResult> OnGet()
        {
            var books = await _bookService.GetBooksAsync();

            BookIsbn = books.First().Key;

            Books = books.Select(b => new SelectListItem
            {
                Value = b.Key.ToString(),
                Text = b.Value
            })
                .ToList();

            await SetBookModelAsync();

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            await SetBookModelAsync();

            return Partial("_BookInformation", Book);
        }
    }
}
