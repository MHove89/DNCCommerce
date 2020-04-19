using System;

namespace DNCommerce.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
    }
}