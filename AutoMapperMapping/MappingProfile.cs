using AutoMapper;
using CarDealer.Models;
using CarDealer.ViewModels;

namespace CarDealer.AutoMapperMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}