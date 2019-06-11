using AutoMapper;
using Kinoman.DTOS;
using Kinoman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kinoman.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>();
        }
    }
}