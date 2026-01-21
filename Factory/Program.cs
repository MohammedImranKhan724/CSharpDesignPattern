//var ser = new NotificationServiceNaive();

//ser.Send("Email", "Welcome!");
//ser.Send("SMS", "OTP is 1234");
//ser.Send("Push", "New message received");

using Factory.FactoryExampleOne;
using Factory.FactoryExampleTwo;
using System;

var service = new NotificationService();

service.Send("Email", "Welcome!");
service.Send("SMS", "OTP is 1234");
service.Send("Push", "New message received");


ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

if (cardDetails is not null)
{
    Console.WriteLine("CardType : " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();