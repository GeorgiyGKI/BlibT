using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServicesInterfaces;
using Shared.DataTransferObject;
using Shared.DataTransferObjects;
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



        /// 
        /// !!!
        /// ПОМЕНЯТЬ STRING TYPE НА СЛОВАРЬ (возможно)
        /// !!!
        /// 

        public async Task<IEnumerable<BookDto>> GetUserBooksByTypeAsync(string userEmail, string type)
        {
            var user = await GetUserWithManyToManyTablesAsync(userEmail);
            var list = new List<Book>();

            switch (type)
            {
                case "UserBookBuyed":
                    foreach (var userBook in user.UserBookBuyeds)
                    {
                        var book = await _repository.Book.GetBookAsync(userBook.BookId, false);
                        list.Add(book);
                    }

                    return _mapper.Map<IEnumerable<BookDto>>(list);

                case "UserBookLike":
                 
                    foreach (var userBook in user.UserBookLikes)
                    {
                        var book = await _repository.Book.GetBookAsync(userBook.BookId, false);
                        list.Add(book);
                    }
                    
                    return _mapper.Map<IEnumerable<BookDto>>(list);

                case "UserBookFavorite":
                    foreach (var userBook in user.UserBookFavorites)
                    {
                        var book = await _repository.Book.GetBookAsync(userBook.BookId, false);
                        list.Add(book);
                    }

                    return _mapper.Map<IEnumerable<BookDto>>(list);

                default:
                    return null;
            }
        }

        public async Task AddBooksByTypeAsync(string userEmail, List<BookDto> bookIds, string type)
        {
            var user = await GetUserWithManyToManyTablesAsync(userEmail);

            switch (type)
            {
                case "UserBookBuyed":
                    foreach (var bookId in bookIds)
                        user.UserBookBuyeds.Add(new UserBookBuyed { BookId = (int)bookId.Id });
                    break;

                case "UserBookLike":
                    foreach (var bookId in bookIds)
                        user.UserBookLikes.Add(new UserBookLike { BookId = (int)bookId.Id });
                    break;

                case "UserBookFavorite":
                    foreach (var bookId in bookIds)
                        user.UserBookFavorites.Add(new UserBookFavorite { BookId = (int)bookId.Id });
                    break;
            }

            await _repository.SaveAsync();
        }


        public async Task RemoveBookByTypeAsync(string userEmail, int bookId, string type)
        {
            var user = await GetUserWithManyToManyTablesAsync(userEmail);

            switch (type)
            {
                case "UserBookLike":
                    var likedBook = user.UserBookLikes.FirstOrDefault(x => x.BookId == bookId);
                    user.UserBookLikes.Remove(likedBook);


                    break;
                case "UserBookFavorite":
                    var favoriteBook = user.UserBookFavorites.FirstOrDefault(x => x.BookId == bookId);
                    user.UserBookFavorites.Remove(favoriteBook);

                    break;
            }

            await _repository.SaveAsync();
        }

        public async Task<bool> IsLikedBook(string userEmail, int bookId)
        {
            var user = await GetUserWithManyToManyTablesAsync(userEmail);

            var foundedBook = user.UserBookLikes.First(b => b.BookId == bookId);
            var isFounded = foundedBook != null;

            return isFounded;
        }

        public async Task<bool> IsFavoriteBook(string userEmail, int bookId)
        {
            var user = await GetUserWithManyToManyTablesAsync(userEmail);

            var foundedBook = user.UserBookFavorites.First(b => b.BookId == bookId);
            var isFounded = foundedBook != null;

            return isFounded;
        }

        public async Task AddMoney(string userEmail, decimal amount)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Email == userEmail);
            if (user != null)
            {
                user.Pocket += amount;
            }

            await _repository.SaveAsync();
        }

        public async Task RemoveMoney(string userEmail, decimal amount)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Email == userEmail);
            if (user != null)
            {
                user.Pocket -= amount;
            }

            await _repository.SaveAsync();
        }

        public async Task<User> GetUserWithManyToManyTablesAsync(string userEmail)
        {
            var user = await _userManager.Users.Include(u => u.UserBookFavorites)
                                               .Include(u => u.UserBookBuyeds)
                                               .Include(u => u.UserBookLikes)
                                               .FirstOrDefaultAsync(u => u.Email == userEmail);

            return user;
        }
    }
}
