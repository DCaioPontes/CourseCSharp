using System.Text;
using Stock.Entities.Enum;

namespace Stock.Entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> Item { get; set; } = new List<OrderItem>();

    public Order()
    {
    }

    public void AddItem(OrderItem item)
    {
        Item.Add(item);
    }

    public void RemoveItems(OrderItem item)
    {
        Item.Remove(item);
    }

    public double Total()
    {
        return 1;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb
    }
}