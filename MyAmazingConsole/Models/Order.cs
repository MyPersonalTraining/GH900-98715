namespace MyAmazingConsole.Models;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Customer Customer { get; set; } = new();
    public List<OrderItem> Items { get; set; } = [];
    public decimal TotalCost => Items.Sum(i => i.TotalCost);
    public OrderStatus Status { get; set; } = OrderStatus.Created;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
