using System;

public interface IPayWithCreditCard
{
    void PayWithCreditCard();
}public interface IPayWithPayPal
{
    
    void PayWithPayPal();
    
}
public interface IPayWithBitcoin
{
    void PayWithBitcoin();
}

public class CreditCardPayment : IPayWithCreditCard
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment with credit card.");
    }
}

public class PayPalPayment : IPayWithPayPal
{
    public void PayWithPayPal()
    {
        Console.WriteLine("Payment with PayPal.");
    }
}

public class BitcoinPayment: IPayWithBitcoin
{ 
    public void PayWithBitcoin()
    {
        Console.WriteLine("Payment with Bitcoin.");
    }
}

public class Program
{
    public static void Main()
    {
        CreditCardPayment creditCardPayment = new CreditCardPayment();
        creditCardPayment.PayWithCreditCard();

        PayPalPayment payPalPayment = new PayPalPayment();
        payPalPayment.PayWithPayPal();

        BitcoinPayment bitcoinPayment = new BitcoinPayment();
        bitcoinPayment.PayWithBitcoin();

        Console.ReadKey();

    }
}
