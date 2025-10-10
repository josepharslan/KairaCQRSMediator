using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands;
using KairaCQRSMediator.Features.Mediator.Handlers.SubscriberHandlers;
using KairaCQRSMediator.Features.Mediator.Queries.SubscriberQueries;
using KairaCQRSMediator.Features.Mediator.Results.SubscriberResults;

namespace KairaCQRSMediator.Mappings
{
    public class SubscriberMapping : Profile
    {
        public SubscriberMapping()
        {
            CreateMap<Subscriber, CreateSubscriberCommand>().ReverseMap();
            CreateMap<Subscriber, GetSubscribersQueryResult>().ReverseMap();
            CreateMap<Subscriber, GetSubscriberByIdQueryResult>().ReverseMap();
            CreateMap<Subscriber, UpdateSubscriberCommand>().ReverseMap();
            CreateMap<GetSubscriberByIdQueryResult, UpdateSubscriberCommand>().ReverseMap();
        }
    }
}
