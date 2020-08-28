using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TellingYourKids.Models;
using TellingYourKids.Models.PostDtos;

namespace TellingYourKids
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostOutputDto>();
            CreateMap<PostInputDto, Post>();
            CreateMap<PostUpdateDto, Post>().ReverseMap();


        }
    }
}
