using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands;
using KairaCQRSMediator.Features.Mediator.Results.SocialMediaResults;

namespace KairaCQRSMediator.Mappings
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, GetSocialMediaQueryResult>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaByIdQueryResult>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaCommand>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaCommand>().ReverseMap();
            CreateMap<SocialMedia, RemoveSocialMediaCommand>().ReverseMap();
        }
    }
}
