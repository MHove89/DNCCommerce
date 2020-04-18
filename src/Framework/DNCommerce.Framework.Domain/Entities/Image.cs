using System;

namespace DNCommerce.Domain.Entities
{
    public abstract class Image : BaseEntity
    {
        public Guid Id { get; set; }

        public string Alt { get; set; }
        
        public string Src { get; set; }
    }
}
