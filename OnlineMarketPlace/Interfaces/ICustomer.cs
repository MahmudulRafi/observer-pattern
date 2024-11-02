namespace OnlineMarketPlace.Interfaces
{
    internal interface ICustomer
    {
        string Name { get; set; }
        void ReceiveProductOffer(string productName);
        void ReceiveNewslatter(string news);
    }
}
