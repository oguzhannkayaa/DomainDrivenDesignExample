using MediatR;
using Order.Application.Repository;
using Order.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.DomainEventHandler
{
    public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
    {

        private readonly IBuyerRepository _buyerRepository;

        public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }
        public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            if (notification.Order.BuyerId == 0)
            {
                //order eventi başladıktan sonra eğer bir buyer yoksa oluşturması için kontrol
                //_buyerRepository.Add(new Buyer(notification.BuyerFirstName,notification.BuyerLastName));
            }
            return Task.CompletedTask;
        }
    }
}
