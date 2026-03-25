using MyAmazingConsole.Models;

namespace MyAmazingConsole.Repositories;

public class InMemoryOrderRepository : IOrderRepository
{
    private readonly Dictionary<Guid, Order> _orders = [];

    public void Add(Order order)
    {
        if (_orders.ContainsKey(order.Id))
            throw new InvalidOperationException($"An order with id '{order.Id}' already exists.");

        _orders[order.Id] = order;
    }

    public Order? GetById(Guid id)
    {
        _orders.TryGetValue(id, out var order);
        return order;
    }

    public IEnumerable<Order> GetAll() => _orders.Values;

    public void Update(Order order)
    {
        if (!_orders.ContainsKey(order.Id))
            throw new KeyNotFoundException($"No order found with id '{order.Id}'.");

        _orders[order.Id] = order;
    }

    public void Delete(Guid id)
    {
        if (!_orders.Remove(id))
            throw new KeyNotFoundException($"No order found with id '{id}'.");
    }
}
