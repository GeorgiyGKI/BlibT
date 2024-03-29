﻿using AutoMapper;
using Entities.Models;
using Shared.DataTransferObject;

namespace WebLibWebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Genre, GenreDto>().ReverseMap();
        }
    }
}
