using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class BookGenresSeeder
    {
        private readonly IRepositoryManager _context;
        public BookGenresSeeder(IRepositoryManager context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            var check = (await _context.Book.GetBookAsync(1, true)).Genres?.Count == 0;
            if (check)
            {
                var genres = await _context.Genre.GetAllGenresAsync(true);
                var books = await _context.Book.GetAllBooksAsync(true);
                var rnd = new Random();

                foreach (var item in books)
                {
                    var id = rnd.Next(1, 9);
                    var genre = genres.FirstOrDefault(g => g.Id == id);
                    item.Genres.Add(genre);
                    await _context.SaveAsync();
                }
            }
        }
    }
}
