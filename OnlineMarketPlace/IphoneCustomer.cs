using OnlineMarketPlace.Interfaces;

namespace OnlineMarketPlace
{
    public class IphoneCustomer : IIphoneCustomer
    {
        public string Name { get; set; }

        public IphoneCustomer(string name)
        {
            Name = name;    
        }

        public void ReceiveProductOffer(string productName)
        {
            Console.WriteLine($"Hello! {Name}. New iphone to roar. \nA new iphone {productName} received in our amazing store");
        }

        public void ReceiveNewslatter(string news)
        {
            Console.WriteLine($"Grettings {Name}! {news}");
        }
    }
}
