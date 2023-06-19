namespace Bridge;

public class Program
{
    public static void Main(string[] args)
    {
        IColor redColor = new RedColor();
        Shape redCircle = new Circle(redColor);
        redCircle.ApplyColor();

        IColor blueColor = new BlueColor();
        Shape blueSquare = new Square(blueColor);
        blueSquare.ApplyColor();
    }
}

// Abstraksi
public abstract class Shape
{
    protected IColor color;

    public Shape(IColor color)
    {
        this.color = color;
    }

    public abstract void ApplyColor();
}

// Implementasi
public interface IColor
{
    void ApplyColor();
}

public class RedColor : IColor
{
    public void ApplyColor()
    {
        Console.WriteLine("Applying red color");
    }
}

public class BlueColor : IColor
{
    public void ApplyColor()
    {
        Console.WriteLine("Applying blue color");
    }
}

// Implementasi konkret
public class Circle : Shape
{
    public Circle(IColor color) : base(color)
    {
    }

    public override void ApplyColor()
    {
        Console.Write("Circle filled with ");
        color.ApplyColor();
    }
}

public class Square : Shape
{
    public Square(IColor color) : base(color)
    {
    }

    public override void ApplyColor()
    {
        Console.Write("Square filled with ");
        color.ApplyColor();
    }
}