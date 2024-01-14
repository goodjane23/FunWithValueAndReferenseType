

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Value type behavior:");
        ValueTypeAssignment();
        Console.WriteLine("Referense type behavior:");
        ReferenceTypeAssignment();
        Console.ReadLine();
    }

    private static void ReferenceTypeAssignment()
    {
        PointRef p1 = new PointRef(0, 0);
        PointRef p2 = p1;

        p1.Dispay();
        p2.Dispay();

        p1.xPos = 100;
        Console.WriteLine("Changed:");
        p1.Dispay();
        p2.Dispay();
    }

    static void ValueTypeAssignment()
    {
        PointStruct p1 = new PointStruct(10,10);
        PointStruct p2 = p1;

        p1.Dispay();
        p2.Dispay();

        p1.xPos = 100;
        Console.WriteLine("Changed:");
        p1.Dispay();
        p2.Dispay();
    }
}


public class PointRef
{
    public int xPos;
    public int yPos;
    public PointRef(int x, int y)
    {
        xPos = x;
        yPos = y;
    }
    internal void Dispay()
    {
        Console.WriteLine($"X = {xPos}, Y = {yPos}");
    }
}

public struct PointStruct
{
    public int xPos;
    public int yPos;
    public PointStruct(int x, int y)
    {
        xPos = x;
        yPos = y;
    }

    internal void Dispay()
    {
        Console.WriteLine($"X = {xPos}, Y = {yPos}");
    }
}