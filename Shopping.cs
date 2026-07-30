namespace ECommerce
{
    public class Shopping
    {
        public void Offer(double? discount)
        {
            double finalDiscount = discount ?? 5;
            System.Console.WriteLine("The final discount is " + finalDiscount);
        }
    }
}