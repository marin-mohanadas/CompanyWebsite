using AutoMapper;
using CompanyWebsite.Entities;
using CompanyWebsite.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebsite.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Partners, UserDTO>()
                .ForMember(dest => dest.PhotoUrl, 
                    opt => opt.MapFrom(src => 
                        src.Photos.FirstOrDefault(x => x.IsMain).Url));

            CreateMap<Photo, PhotoDto>();
        }
    }
}
