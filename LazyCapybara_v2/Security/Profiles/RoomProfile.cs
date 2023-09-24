namespace LazyCapybara_v2.Security.Profiles
{
    using AutoMapper;
    using Domain.Models;
    using LazyCapybara_v2.Security.Dto;

    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomDto>()
                .ForMember(dest => dest.EnergyMetering, opt =>
                {
                    opt.MapFrom(src =>
                        (src.EnergyMetering.Count > 0 ? src.EnergyMetering.Peek() : 0)
                    );
                });
        }
    }
}
