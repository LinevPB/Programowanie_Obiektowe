using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public Shape(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Height = height;
        Width = width;
    }
    public virtual void Draw()
    {
        Console.WriteLine($"Rysowanie kształtu o współrzędnych x={X}, y={Y} oraz wysokości = {Height} i długości = {Width}");
    }
}

public class Rectangle : Shape
{
    public Rectangle(int x, int y, int width, int height) : base(x, x, width, width) { }

    public override void Draw()
    {
        Console.WriteLine($"Rysowanie kwadratu o boku x={X}, y={Width}");
    }
}

public class Triangle : Shape
{
    public Triangle(int a, int h): base(a, a, h, h) { }
    
    public override void Draw()
    {
        Console.WriteLine($"Rysowanie trójkątu o podstawie a={X} oraz wysokości = {Height}");
    }
}

public class Circle : Shape
{
    public Circle(int x, int y, int radius) : base(x, y, radius, radius) { }
    public override void Draw()
    {
        Console.WriteLine($"Rysowanie koła o współrzędnych x={X}, y={Y} oraz promieniu = {Height}");
    }
}

public class Program
{
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle(3,4,5,6),
            new Triangle(2, 3),
            new Circle(3, 4, 10)
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
