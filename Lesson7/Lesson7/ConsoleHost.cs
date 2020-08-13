using Lesson7.DAL;
using OnlineStore.DAL.Data;
using System.Threading;

namespace Lesson7
{
    internal class ConsoleHost
    {
        private readonly PurchasedOrdersRepository _purchasedOrdersRepository;

        public ConsoleHost()
        {
            this._purchasedOrdersRepository = new PurchasedOrdersRepository();
        }

        internal void Run()
        {
            // init some data
            DataSeeder.Initialize();

            var allOrders = this._purchasedOrdersRepository.GetAllPurchases();

            var orderProducer = new PurchasedOrdersProducer(allOrders);
            Thread orderProducerThread = new Thread(orderProducer.Produce);
            orderProducerThread.Start();

            var orderProcessor = new PurchasedOrderProcessor(orderProducer.GetOrdersQueue());
            Thread orderProcessorThread = new Thread(orderProcessor.ProcessItem);
            orderProcessorThread.Start();
        }
        
    }
}