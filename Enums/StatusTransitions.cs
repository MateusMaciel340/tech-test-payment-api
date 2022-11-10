namespace tech_test_payment_api.Enums
{
    public enum StatusTransitions
    {
        Awaiting_Payment = 0, PaymentAccept = 1, SentToCarrier = 2,
        Delivered = 3, Canceled = 4
    }
}