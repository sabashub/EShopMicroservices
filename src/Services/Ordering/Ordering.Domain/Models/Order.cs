﻿using Ordering.Domain.Events;

namespace Ordering.Domain.Models
{
    public class Order : Aggregate<OrderId>
    {
        private readonly List<OrderItem> _orderItems = new();
        public IReadOnlyList<OrderItem> OrderItems => _orderItems.AsReadOnly();
        public CustomerId CustomerId { get; private set; } = default!;
        public OrderName OrderName { get; private set; } = default!;
        public Address ShippingAdress { get; private set; } = default!;
        public Address BillingAdress { get; private set; } = default!;
        public Payment Payment { get; private set; } = default!;
        public OrderStatus Status { get; private set; } = OrderStatus.Pending;

        public decimal TotalPrice
        {
            get => OrderItems.Sum(x => x.Price * x.Quantity);
            private set { }
        }

        public static Order Create(OrderId id, CustomerId customerId, OrderName orderName, Address address, Address shippingAdress, Address billingAdress, Payment payment, OrderStatus status)
        {
            var order = new Order
            {
                Id = id,
                CustomerId = customerId,
                OrderName = orderName,
                ShippingAdress = shippingAdress,
                BillingAdress = billingAdress,
                Payment = payment,
                Status = status
            };
            order.AddDomainEvent(new OrderCreatedEvent(order));

            return order;
        }
        public void Update(OrderName orderName, Address shippingAdress, Address billingAdress, Payment payment, OrderStatus status)
        {
            OrderName = orderName;
            ShippingAdress = shippingAdress;
            BillingAdress = billingAdress;
            Payment = payment;
            Status = status;

            AddDomainEvent(new OrderUpdatedEvent(this));

        }

        public void Add(ProductId productId, int quantity, decimal price)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantity);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

            var orderItem = new OrderItem(Id, productId, quantity, price);
            _orderItems.Add(orderItem);
        }

        public void Remove(ProductId productId)
        {
            var orderItem = _orderItems.FirstOrDefault(x => x.ProductId == productId);
            if (orderItem != null)
            {
                {
                    _orderItems.Remove(orderItem);
                }
            }
        }

    }
    }
