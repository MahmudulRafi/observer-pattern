using OnlineMarketPlace;
using OnlineMarketPlace.Interfaces;

IMarketPlace marketPlace = new  MarketPlace();

marketPlace.Subscribe(new IphoneCustomer("Mr. M"));
marketPlace.Subscribe(new AndroidCustomer("Mr. N"));
marketPlace.Subscribe(new AndroidCustomer("Mr. O"));
marketPlace.Subscribe(new AndroidCustomer("Mr. P"));

marketPlace.SendProductOffer<IIphoneCustomer>("IPhone 16 Pro Max");
marketPlace.SendProductOffer<IAndroidCustomer>("Moto G85");

marketPlace.SendNewslatter("Upto 25% offer in new year");
