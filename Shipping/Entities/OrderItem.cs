namespace Stock.Entities;

public class OrderItem
{
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Product Product { get; set; }

    public OrderItem()
    {
    }

    public OrderItem(int quantity, double price, Product product)
    {
        Quantity = quantity;
        Price = price;
        Product = product;
    }

    public double SubTotal()
    {
        double price = Product.Price * Quantity;
        return price;
    }

    public override string ToString()
    {
        return $"{Product.Name}, ${Price.ToString("f2")}, Quantity: {Quantity}, Subtotal ${SubTotal().ToString("F2")}";
    }
}