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
                    foreach (var userBook in user.BuyedBooks)
                    {
                        var book = await _repository.Book.GetBookAsync(userBook.Id, false);
                        list.Add(book);
                    }

                    return _mapper.Map<IEnumerable<BookDto>>(list);

                case "UserBookLike":

                    foreach (var userBook in user.LikedBooks)
                    {
                        var book = await _repository.Book.GetBookAsync(userBook.Id, false);
                        list.Add(book);
                    }

                    return _mapper.Map<IEnumerable<BookDto>>(list);

                case "UserBookFavorite":
                    foreach (var userBook in user.FavoriteBooks)
                    {
                        var book = await _repository.Book.GetBookAsync(userBook.Id, false);
                        list.Add(book);
                    }

                    return _mapper.Map<IEnumerable<BookDto>>(list);

                default:
                    return null;
            }
        }

        public async Task AddBooksByTypeAsync(string userEmail, List<BookDto> bookDtos, string type)
        {
            var user = await GetUserWithManyToManyTablesAsync(userEmail);

            switch (type)
            {
                case "UserBookBuyed":
                    foreach (var bookDto in bookDtos)
                    {
                        var book = await _repository.Book.GetBookAsync((int)bookDto.Id, true);
                        user.BuyedBooks.Add(book);
                    }

                    break;

                case "UserBookLike":
                    foreach (var bookDto in bookDtos)
                    {
                        var book = await _repository.Book.GetBookAsync((int)bookDto.Id, true);
                        user.LikedBooks.Add(book);
                    }
                    break;

                case "UserBookFavorite":
                    foreach (var bookDto in bookDtos)
                    {
                        var book = await _repository.Book.GetBookAsync((int)bookDto.Id, true);
                        user.FavoriteBooks.Add(book);
                    }

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
                    var likedBook = user.LikedBooks.FirstOrDefault(x => x.Id == bookId);
                    user.LikedBooks.Remove(likedBook);


                    break;
                case "UserBookFavorite":
                    var favoriteBook = user.FavoriteBooks.FirstOrDefault(x => x.Id == bookId);
                    user.FavoriteBooks.Remove(favoriteBook);

                    break;
            }

            await _repository.SaveAsync();
        }

        public async Task<bool> IsLikedBook(string userEmail, int bookId)
        {
            var user = await GetUserWithManyToManyTablesAsync(userEmail);

            var foundedBook = user.LikedBooks.First(b => b.Id == bookId);
            var isFounded = foundedBook != null;

            return isFounded;
        }

        public async Task<bool> IsFavoriteBook(string userEmail, int bookId)
        {
            var user = await GetUserWithManyToManyTablesAsync(userEmail);

            var foundedBook = user.FavoriteBooks.First(b => b.Id == bookId);
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
            var user = await _userManager.Users.Include(u => u.FavoriteBooks)
                                               .Include(u => u.BuyedBooks)
                                               .Include(u => u.LikedBooks)
                                               .FirstOrDefaultAsync(u => u.Email == userEmail);

            return user;
        }
    }
}
