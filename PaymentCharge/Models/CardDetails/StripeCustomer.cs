namespace PaymentCharge.Models.CardDetails
{
    public record StripeCustomer(
        string Name,
        string Email,
        string CustomerId);
}
