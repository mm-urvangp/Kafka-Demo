namespace KafkaConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumeMessage consumeMessage = new ConsumeMessage();
            consumeMessage.ReadMessage();
        }
    }
}
