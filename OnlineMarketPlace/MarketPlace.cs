using OnlineMarketPlace.Interfaces;

namespace OnlineMarketPlace
{
    internal class MarketPlace : IMarketPlace
    {
        private readonly IList<ICustomer> _customers;

        public MarketPlace()
        {
            _customers = [];
        }

        public void Subscribe(ICustomer customer)
        {
            if (customer is not null)
                _customers.Add(customer);

        }

        public void Unsubscribe(ICustomer customer)
        {
            if (customer is not null)
                _customers.Remove(customer);
        }

        public void SendProductOffer<T>(string productName)
        {
            foreach (var customer in _customers.OfType<T>())
            {
                (customer as ICustomer)?.ReceiveProductOffer(productName);
            }
        }

        public void SendNewslatter(string news)
        {
            foreach (var customer in _customers)
            {
                customer.ReceiveNewslatter(news);
            }
        }
    }
}

