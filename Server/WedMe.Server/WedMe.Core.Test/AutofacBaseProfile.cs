using System;
using AutoMapper;
using WedMe.Core.Dto.Models;
using WedMe.Core.Dto.Profile;
using WedMe.Core.Models;
using Xunit;

namespace WedMe.Core.Test
{
    public class AutofacBaseProfile
    {
        [Fact]
        public void ContactDto_ToContact_Success()
        {
            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile(typeof(BaseProfile))
            );
            var mapper = configuration.CreateMapper();

            var contactDto = new ContactDto()
            {
                Name = "test"
            };
            var contact = mapper.Map<Contact>(contactDto);
            Assert.Equal(contactDto.Name, contact.Name);
        }
        [Fact]
        public void Contact_ToContactDto_Success()
        {
            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile(typeof(BaseProfile))
            );
            var mapper = configuration.CreateMapper();

            var contact = new Contact(Guid.NewGuid())
            {
                Name = "test"
            };
            var contactDto = mapper.Map<ContactDto>(contact);
            Assert.Equal(contactDto.Name, contact.Name);
        }
    }
}