namespace tech_test_payment_api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        public int SellerId { get; set; }
    }
}