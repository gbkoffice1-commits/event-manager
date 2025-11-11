public class Order
{
    public string Id { get; set; } 
    public string CustomerId { get; set; } 
    public List<Product> Products { get; set; } 
    public DateTime OrderDate { get; set; } 
    public decimal TotalAmount { get; set; } 
}