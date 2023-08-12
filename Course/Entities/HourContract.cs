namespace Course.Entities;

public class HourContract
{
    public DateTime Data { get; set; }
    public double ValuePerHour { get; set; }
    public int Hours { get; set; }

    public HourContract ()
    {
    }

    public HourContract(DateTime date, double valuePerHour, int hours)
    {
        Data = date;
        ValuePerHour = valuePerHour;
        Hours = hours;
    }

    public double TotalValue ()
    {
        return Hours * ValuePerHour;
    }
}