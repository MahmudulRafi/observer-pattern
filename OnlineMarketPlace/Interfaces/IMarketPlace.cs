namespace OnlineMarketPlace.Interfaces
{
    internal interface IMarketPlace
    {
        void Subscribe(ICustomer customer);
        void Unsubscribe(ICustomer customer);
        void SendProductOffer<T>(string productName);
        void SendNewslatter(string news);
    }
}
