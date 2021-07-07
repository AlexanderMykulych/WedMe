using System.Threading.Tasks;
using AutoMapper;
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

        public Mutation(IMapper mapper)
        {
            _mapper = mapper;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Contact> addContact([ScopedService] ApplicationDbContext dbContext, ContactDto contact)
        {
            var contactModel = _mapper.Map<Contact>(contact);
            var added = await dbContext.Contacts.AddAsync(contactModel);
            await dbContext.SaveChangesAsync();
            return added.Entity;
        }
    }
}