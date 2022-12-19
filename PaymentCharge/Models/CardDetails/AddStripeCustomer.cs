namespace PaymentCharge.Models.CardDetails
{
    public record AddStripeCustomer(
         string Email,
         string Name,
         AddStripeCard CreditCard);
}
