namespace FacadeDP
{
    public class PaymentService : IPaymentService
    {
        public void pay(double amount, string item)
        {
            Console.WriteLine($"Payment of {amount} for item {item} has been processed.");
        }
    }
    {
    }
}
