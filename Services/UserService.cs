using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServicesInterfaces;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserService(UserManager<User> UserManager,
            IRepositoryManager repository,
            IMapper mapper)
        {
            _userManager = UserManager;
            _repository = repository;
            _mapper = mapper;
        }
       
        public async Task<IEnumerable<BookDto>> GetLikedBooksByEmailAsync(string userEmail)
        {

            var user = await GetUserWithNavigationPropertyAsync(u => u.UserBookLikes, userEmail);
           
            foreach (var userBook in user.UserBookLikes)
            {
                var book = await _repository.Book.GetBookAsync(userBook.BookId, false);
                user.LikedBooks.Add(book);
            }

            var booksDto = _mapper.Map<IEnumerable<BookDto>>(user.LikedBooks);
            return booksDto;
        }

        public async Task<IEnumerable<BookDto>> GetFavoritBooksByEmailAsync(string userEmail)
        {
            var user = await GetUserWithNavigationPropertyAsync(u => u.UserBookFavorites, userEmail);

            foreach (var userBookFavorite in user.UserBookFavorites)
            {
                var book = await _repository.Book.GetBookAsync(userBookFavorite.BookId, false);
                user.FavoriteBooks.Add(book);
            }

            var booksDto = _mapper.Map<IEnumerable<BookDto>>(user.FavoriteBooks);
            return booksDto;
        }

        public async Task AddLikedBookAsync(string userEmail, int bookId)
        {
            var user = await GetUserWithNavigationPropertyAsync(u => u.UserBookLikes, userEmail);

            user.UserBookLikes.Add(new UserBookLike { BookId = bookId });

            await _repository.SaveAsync();
        }

        public async Task AddFavoritBookAsync(string userEmail, int bookId)
        {
            var user = await GetUserWithNavigationPropertyAsync(u => u.UserBookFavorites, userEmail);

            user.UserBookFavorites.Add(new UserBookFavorite { BookId = bookId });

            await _repository.SaveAsync();
        }

        public async Task RemoveLikedBookAsync(string userEmail, int bookId)
        {
            var user = await GetUserWithNavigationPropertyAsync(u => u.UserBookLikes, userEmail);

            var book = user.UserBookLikes.FirstOrDefault(x => x.BookId == bookId);
            user.UserBookLikes.Remove(book);

            await _repository.SaveAsync();
        }

        public async Task RemoveFavoritBookAsync(string userEmail, int bookId)
        {
            var user = await GetUserWithNavigationPropertyAsync(u => u.UserBookFavorites, userEmail);

            var book = user.UserBookFavorites.FirstOrDefault(x => x.BookId == bookId);
            user.UserBookFavorites.Remove(book);

            await _repository.SaveAsync();
        }

        public async Task<bool> IsLikedBook(string userEmail, int bookId)
        {
            var user = await GetUserWithNavigationPropertyAsync(u => u.UserBookLikes, userEmail);

            var foundedBook = user.UserBookLikes.First(b => b.BookId == bookId);
            var isFounded = foundedBook != null;

            return isFounded;
        }

        public async Task<bool> IsFavoriteBook(string userEmail, int bookId)
        {
            var user = await GetUserWithNavigationPropertyAsync(u => u.UserBookFavorites, userEmail);

            var foundedBook = user.UserBookFavorites.First(b => b.BookId == bookId);
            var isFounded = foundedBook != null;

            return isFounded;
        }

        public async Task<User> GetUserWithNavigationPropertyAsync(Expression<Func<User, object>> navigationProperty, string userEmail)
        {
            var user = await _userManager.Users
                .Include(navigationProperty)
                .FirstOrDefaultAsync(u => u.Email == userEmail);

            return user;
        }
    }
}
