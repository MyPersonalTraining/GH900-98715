using MyAmazingConsole.Models;

namespace MyAmazingConsole.Repositories;

public interface IOrderRepository
{
    void Add(Order order);
    Order? GetById(Guid id);
    IEnumerable<Order> GetAll();
    void Update(Order order);
    void Delete(Guid id);
}
