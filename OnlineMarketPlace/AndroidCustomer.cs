using OnlineMarketPlace.Interfaces;

namespace OnlineMarketPlace
{
    internal class AndroidCustomer : IAndroidCustomer
    {
        public string Name { get; set; }

        public AndroidCustomer(string name)
        {
            Name = name;    
        }

        public void ReceiveProductOffer(string productName)
        {
            Console.WriteLine($"Hello! {Name}.  Here is you brand new android. \nA android phone {productName} received in our amazing store");
        }

        public void ReceiveNewslatter(string news)
        {
            Console.WriteLine($"Grettings {Name}! {news}");
        }
    }
}
