namespace IceTask1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public class CartItem
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
