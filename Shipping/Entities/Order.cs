using System.Text;
using Stock.Entities.Enum;
using System;

namespace Stock.Entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> Item { get; set; } = new List<OrderItem>();

    public Order()
    {
    }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
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
        double sum = 0;
        foreach (OrderItem items in Item)
        {
            sum += items.SubTotal();
        }

        return sum;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("ORDER SUMMARY:");
        sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine("Order status: " + Status);
        sb.AppendLine($"Client: {Client.Name} {Client.BirthDate.ToString("dd/MM/yyyy")} - {Client.Email}");
        sb.AppendLine("Order items:");
        foreach (var item in Item)
        {
            sb.AppendLine($"{item}");
        }
        sb.AppendLine($"Total price: ${Total().ToString("F2")}");
        return sb.ToString();
    }
}