using System;
namespace DNCommerce.Domain.Entities
{
    public class OrderLine : BaseEntity
    {
        public Guid Id { get; set; }
        
        public Product Product { get; set; }
        
        public int Amount { get; set; }
        
        public int Price { get; set; }
        
        public Guid OrderId { get; set; }
        
        public Order Order { get; set; }
    }
}