using System;
using System.Collections.Generic;
using Flunt.Notifications;

namespace PagamentoContext.Shared.Entities
{
    public abstract class BaseEntity : Notifiable<Notification>
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}