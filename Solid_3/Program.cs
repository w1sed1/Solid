using System;
//Проблема полягає у порушенні принципу підстановки Лісков
//Згідно з цим принципом, підклас повинен мати можливість замінити батьківський клас без порушення функціональності програми.
//У цьому випадку Square не поводиться як Rectangle, оскільки для квадрата ширина і висота завжди повинні бути однаковими, а це порушує поведінкові очікування для прямокутника.
//Зробимо Прямокутник і Квадрат окремими класами.
class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

class Square
{
    public int Side { get; set; }

    public int GetSquareArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine(rect.GetRectangleArea());

        Square square = new Square { Side = 5 };
        Console.WriteLine(square.GetSquareArea());

        Console.ReadKey();
    }
}