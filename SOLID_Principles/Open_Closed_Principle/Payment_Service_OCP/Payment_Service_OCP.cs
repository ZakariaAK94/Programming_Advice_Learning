using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PaymentService
{
    private readonly IPaymentProcessor _IPayService;
    public PaymentService(IPaymentProcessor IPayService) => _IPayService = IPayService;
    public void Process() => _IPayService.Process();

}

public interface IPaymentProcessor
{
    public void Process();
}
public class PayPalPaymentProcessor : IPaymentProcessor
{
    private decimal _amount;
    public PayPalPaymentProcessor(decimal amount) => _amount = amount;
    public void Process() => Console.WriteLine($"PayPal Service: Your payment of {_amount:C} was processed successfully!");

}

public class CreditCardPaymentProcessor: IPaymentProcessor
{
    private decimal _amount;
    public CreditCardPaymentProcessor(decimal amount) => _amount = amount;
    public void Process() => Console.WriteLine($"Credit Card Service: Your payment of {_amount:C} was processed successfully!");

}

public class BankTransferPaymentProcessor: IPaymentProcessor
{
    private decimal _amount;
    public BankTransferPaymentProcessor(decimal amount) => _amount = amount;    

    public void Process() => Console.WriteLine($"Bank Transfer Service: Your payment of {_amount:C} was processed successfully!");

}

public class BitcoinPaymentProcessor : IPaymentProcessor
{
    private decimal _amount;
    public BitcoinPaymentProcessor(decimal amount) => _amount = amount;
    public void Process() => Console.WriteLine($"Bitcoin Service: Your payment of {_amount:C} was processed successfully!");

}

class Program
{
    static void Main()
    {
        List<PaymentService> PaymentServices = new List<PaymentService>()
        {
            new PaymentService(new PayPalPaymentProcessor(35.78m)),
            new PaymentService(new CreditCardPaymentProcessor(15.34m)),
            new PaymentService(new BankTransferPaymentProcessor(20m)),
            new PaymentService(new BitcoinPaymentProcessor(27.5m))
        };
        
        
        foreach(PaymentService paymentService in PaymentServices)
            paymentService.Process();

        Console.ReadLine();

    }
}

