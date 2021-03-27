using AutoMapper;
using MyAPI.DTOs;
using MyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Model, ReadModelDto>();
            CreateMap<CreateModelDtos, Model>();
        }
    }
}
