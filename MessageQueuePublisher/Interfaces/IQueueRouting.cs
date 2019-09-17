namespace MessageQueuePublisher.Interfaces
{
    public interface IQueueRouting
    {
        bool TestQueue(string message);

        //bool MessageQueueLogging(string message);
        //bool RelationalDatabaseLogging(string message);
        //bool ApplicationLogging(string message);
        //bool ExternalTransactionLogging(string message);
        //bool InternalTransactionLogging(string message);
        bool LoggingQueue(string message);
    }
}