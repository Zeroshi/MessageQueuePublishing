using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageQueuePublisher.Interfaces
{
    public interface IMessageQueuePublishing
    {
        Task<bool> SendMessage(string ExchangeName, string RoutingKey, byte[] message);
    }
}