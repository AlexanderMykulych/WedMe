using System;
using WedMe.Core.Dto.Models;
using WedMe.Core.Models;

namespace WedMe.Core.Dto.Profile
{
    public class BaseProfile: AutoMapper.Profile
    {
        public BaseProfile()
        {
            BaseEntityMap<Contact, ContactDto>();
        }

        private void BaseEntityMap<T, Tdto>() where T: BaseEntity
        {
            CreateMap<Tdto, T>()
                .ForCtorParam("Id", ctx => ctx.MapFrom(dto => Guid.NewGuid()))
                .ReverseMap();
        }
    }
}