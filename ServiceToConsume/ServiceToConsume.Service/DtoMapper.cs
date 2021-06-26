using AutoMapper;
using ServiceToConsume.Core.DTOs;
using ServiceToConsume.Core.Models;

namespace ServiceToConsume.Service
{
    public class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}