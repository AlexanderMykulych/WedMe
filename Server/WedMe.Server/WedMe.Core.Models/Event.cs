using System;

namespace WedMe.Core.Models
{
    public record Event: BaseEntity
    {
        public Event(Guid id) : base(id)
        {
        }
    }
}