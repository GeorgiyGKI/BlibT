﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        public ICollection<Book> FavoriteBooks { get; set; } = new List<Book>();
        public ICollection<UserBookFavorite> UserBookFavorites { get; set; }
        public ICollection<Book> LikedBooks { get; set; } = new List<Book>();
        public ICollection<UserBookLike> UserBookLikes { get; set; }
    }
}
