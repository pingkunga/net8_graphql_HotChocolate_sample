using AutoMapper;
using GraphQLAPI.Infra.Models;

namespace GraphQLAPI.DTOs;
public class AppMapperProfile : Profile
{
    public AppMapperProfile()
    {
        CreateMap<SupplierModel, SupplierDTO>().ReverseMap();
    }
}