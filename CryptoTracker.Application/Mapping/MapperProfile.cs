using AutoMapper;
using CryptoTracker.Application.Dto;
using CryptoTracker.Domain.Entities;

namespace CryptoTracker.Application.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CryptoCurrency, CryptoCurrencyDto>()
                .ForMember(dest => dest.Markets, opt => opt.MapFrom(src => src.Markets));

            CreateMap<Market, MarketDto>()
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price.Value));
        }
    }
}
