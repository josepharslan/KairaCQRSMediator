using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;
using KairaCQRSMediator.Features.Mediator.Results.ContactInfoResults;

namespace KairaCQRSMediator.Mappings
{
    public class ContactInfoMapping : Profile
    {
        public ContactInfoMapping()
        {
            CreateMap<ContactInfo, GetContactQueryResult>().ReverseMap();
            CreateMap<ContactInfo, GetContactByIdQueryResult>().ReverseMap();
            CreateMap<ContactInfo, CreateContactCommand>().ReverseMap();
            CreateMap<ContactInfo, UpdateContactCommand>().ReverseMap();
            CreateMap<ContactInfo, RemoveContactCommand>().ReverseMap();
        }
    }
}
