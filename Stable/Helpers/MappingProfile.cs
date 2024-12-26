using AutoMapper;
using Stable.Dtos;
using Stable.Models;

namespace Stable.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<OwnerDTo,Owner>().ReverseMap();
        }
    }
}
