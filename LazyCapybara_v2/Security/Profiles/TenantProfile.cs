namespace LazyCapybara_v2.Security.Profiles
{
    using Domain.Models;
    using LazyCapybara_v2.Security.Dto;
    using AutoMapper;

    public class TenantProfile : Profile
    {
        public TenantProfile()
        {
            CreateMap<Tenant, TenantDto>();
        }
    }
}
