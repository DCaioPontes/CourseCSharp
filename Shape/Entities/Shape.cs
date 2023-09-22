namespace Shape.Entities;

public class Shape
{
    public Color _color{ get; set; }

    public Shape()
    {
    }

    public Shape(Color color)
    {
        _color = color;
    }

    private double area()
    {
        return 1;
    }
}