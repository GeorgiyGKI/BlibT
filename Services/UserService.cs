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
        public async Task<IEnumerable<BookDto>> GetBooksByUserEmailAsync(string UserEmail)
        {

            var user = new User();
            if (user is null)
                return null;
            
            var booksDto = _mapper.Map<IEnumerable<BookDto>>(user.FavoriteBooks);
            return booksDto;
        }

        public async Task<IEnumerable<BookDto>> GetLikedBooksByEmailAsync(string UserEmail)
        {

            var user = await _userManager.Users
                .Include(u => u.UserBookLikes)
                .FirstOrDefaultAsync(u => u.Email == UserEmail);

            var booksDto = _mapper.Map<IEnumerable<BookDto>>(user.LikedBooks);
            return booksDto;
        }

        public async Task<IEnumerable<BookDto>> GetFavoritBooksByEmailAsync(string UserEmail)
        {

            var user = await _userManager.Users
              .Include(u => u.UserBookFavorites)
              .FirstOrDefaultAsync(u => u.Email == UserEmail);

            var booksDto = _mapper.Map<IEnumerable<BookDto>>(user.FavoriteBooks);
            return booksDto;
        }

        public async Task<IEnumerable<BookDto>> AddLikedBookAsync(string UserEmail)
        {

            var user = await _userManager.Users
              .Include(u => u.UserBookFavorites)
              .FirstOrDefaultAsync(u => u.Email == UserEmail);

            var booksDto = _mapper.Map<IEnumerable<BookDto>>(user.FavoriteBooks);
            return booksDto;
        }
        public async Task<IEnumerable<BookDto>> AddFavoritBookAsync(string UserEmail)
        {

            var user = await _userManager.Users
              .Include(u => u.UserBookFavorites)
              .FirstOrDefaultAsync(u => u.Email == UserEmail);

            var booksDto = _mapper.Map<IEnumerable<BookDto>>(user.FavoriteBooks);
            return booksDto;
        }
    }
}
