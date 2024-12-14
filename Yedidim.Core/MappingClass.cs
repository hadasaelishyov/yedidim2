using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.DTOs;
using Yedidim.Core.Entities;

namespace Yedidim.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CallFromPeople, CallsDto>().ReverseMap();
            CreateMap<TypesOfCall, TypesOfCallDto>().ReverseMap();
            CreateMap<Volunteer, VolunteerDto>().ReverseMap();
        }
    }
}
