public abstract class Figure { }

public class Triangle : Figure
{
    public int Base { get; set; }
    public int Height { get; set; }
}

public class Square : Figure
{
    public int Side { get; set; }
}
