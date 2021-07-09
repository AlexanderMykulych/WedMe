using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using HotChocolate;
using HotChocolate.Data;
using WedMe.Core.Dto.Models;
using WedMe.Core.EfCore.DbContext;
using WedMe.Core.Models;

namespace WedMe.Core.HotChocolate
{
    public class Mutation
    {
        private readonly IMapper _mapper;
        private readonly IValidator<ContactDto> _contactDtoValidator;

        public Mutation(IMapper mapper, IValidator<ContactDto> contactDtoValidator) {
            _mapper = mapper;
            _contactDtoValidator = contactDtoValidator;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Contact> addContact([ScopedService] ApplicationDbContext dbContext, ContactDto contact)
        {
            await _contactDtoValidator.ValidateAndThrowAsync(contact);
            var contactModel = _mapper.Map<Contact>(contact);
            var added = await dbContext.Contacts.AddAsync(contactModel);
            await dbContext.SaveChangesAsync();
            return added.Entity;
        }
    }
}