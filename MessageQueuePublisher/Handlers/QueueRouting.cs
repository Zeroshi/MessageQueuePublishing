using MessageQueuePublisher.Interfaces;
using System;

namespace MessageQueuePublisher.Handlers
{
    public class QueueRouting : IQueueRouting
    {
        public bool LoggingQueue(string message)
        {
            throw new NotImplementedException();
        }

        public bool TestQueue(string message)
        {
            throw new NotImplementedException();
        }
    }
}