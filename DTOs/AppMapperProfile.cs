using AutoMapper;
using GraphQLAPI.Infra.Models;

namespace GraphQLAPI.DTOs;
public class AppMapperProfile : Profile
{
    public AppMapperProfile()
    {
        CreateMap<SupplierModel, SupplierDTO>().ReverseMap();
        CreateMap<SuppilerCreateDTO, SupplierDTO>()
            .ForMember(dest => dest.Id, opt => opt.Ignore()) // Ignore the Id property
            .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null)); // Apply the global condition
    }
}