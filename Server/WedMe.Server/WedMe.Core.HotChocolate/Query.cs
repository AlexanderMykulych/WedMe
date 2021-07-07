using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using WedMe.Core.EfCore.DbContext;
using WedMe.Core.Models;

namespace WedMe.Core.HotChocolate
{
    public class Query
    {
        [UseDbContext(typeof(ApplicationDbContext))]
        public IEnumerable<Contact> GetContact([ScopedService] ApplicationDbContext dbContext)
        {
            return dbContext.Contacts.ToList();
        }
    }
}