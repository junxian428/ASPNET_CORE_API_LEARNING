using AutoMapper;
using SSLAPI.Dto;
using SSLAPI.Models;

namespace SSLAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //GET
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            // POST & PUT
            CreateMap<CategoryDto, Category>();
            CreateMap<CountryDto, Country>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<ReviewDto, Review>();
            CreateMap<ReviewerDto, Reviewer>();
            //GET
            CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Review, ReviewDto>();
            CreateMap<Reviewer, ReviewerDto>();
        }
    }
}
