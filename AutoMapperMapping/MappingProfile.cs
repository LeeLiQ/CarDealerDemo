using System.Linq;
using AutoMapper;
using CarDealer.Models;
using CarDealer.ViewModels;

namespace CarDealer.AutoMapperMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resource
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();

            //API Resource to Domain
            CreateMap<VehicleResource, Vehicle>()
                .ForMember(destination => destination.ContactName,
                            operation => operation.MapFrom(source => source.Contact.Name))
                .ForMember(destination => destination.ContactEmail,
                            operation => operation.MapFrom(source => source.Contact.Email))
                .ForMember(destination => destination.ContactPhone,
                            operation => operation.MapFrom(source => source.Contact.Phone))
                .ForMember(destination => destination.Features,
                            operation => operation.MapFrom(source =>
                                source.Features.Select(id => new VehicleFeature { FeatureId = id })));
        }
    }
}