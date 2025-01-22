using AutoMapper;
using Yedidim.Api.Models;
using Yedidim.Core.Entities;

namespace Yedidim.Api
{
    public class MappingPostModel:Profile
    {
        public MappingPostModel()
        {
            CreateMap<CallFromPeople, CallsPostModel>().ReverseMap();
            CreateMap<TypesOfCall, TypesOfCallModel>().ReverseMap();
            CreateMap<Volunteer,VolunteerModel>().ReverseMap();
        }

    }
}
