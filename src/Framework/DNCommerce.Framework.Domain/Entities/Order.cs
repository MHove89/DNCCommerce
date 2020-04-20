using System;
using System.Collections;
using System.Collections.Generic;

namespace DNCommerce.Domain.Entities
{
    public class Order : BaseEntity
    {
        private ICollection<OrderLine> _orderLines { get; set; }

        public Guid Id { get; set; }

        public string OrderNumber { get; set; }

        public DateTime CompletedDate { get; set; }

        public string OrderTotal { get; set; }

        public string PaymentTotal { get; set; }

        public string TaxTotal { get; set; }

        public string SubTotal { get; set; }

        public string Note { get; set; }

        public Guid BillingAddressId { get; set; }

        public Address BillingAddress { get; set; }

        public Guid DeliveryAddressId { get; set; }

        public Address DeliveryAddress { get; set; }

        public ICollection<OrderLine> OrderLines
        {
            get => _orderLines ?? (_orderLines = new List<OrderLine>());
            protected set => _orderLines = value;
        }
    }
}
