using System;
using System.Text;
/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.*/
/*
Код порушує принцип розділення інтерфейсів (Interface Segregation Principle, ISP), оскільки інтерфейс IItem змушує реалізовувати методи, які не потрібні кожному класу.
Розділимо інтерфейс IItem на кілька дрібніших інтерфейсів, кожен із яких відповідає окремій функціональності. 
*/
interface IPricedItem
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);
}

interface ISizedItem
{
    void SetSize(byte size);
}

interface IColoredItem
{
    void SetColor(byte color);
}

interface INamedItem
{
    void SetName(string name);
}

class Book : IPricedItem, IDiscountable, INamedItem
{
    private double price;
    private string name;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Ціна на книгу встановлена: {price} грн");
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Знижка '{discount}' застосована до книги");
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Промокод '{promocode}' застосований до книги");
    }

    public void SetName(string name)
    {
        this.name = name;
        Console.WriteLine($"Назва книги встановлена: {name}");
    }
}

class Outerwear : IPricedItem, IDiscountable, ISizedItem, IColoredItem, INamedItem
{
    private double price;
    private byte size;
    private byte color;
    private string name;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Ціна на верхній одяг встановлена: {price} грн");
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Знижка '{discount}' застосована до верхнього одягу");
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Промокод '{promocode}' застосований до верхнього одягу");
    }

    public void SetSize(byte size)
    {
        this.size = size;
        Console.WriteLine($"Розмір верхнього одягу встановлений: {size}");
    }

    public void SetColor(byte color)
    {
        this.color = color;
        Console.WriteLine($"Колір верхнього одягу встановлений: {color} ");
    }

    public void SetName(string name)
    {
        this.name = name;
        Console.WriteLine($"Назва верхнього одягу встановлена: {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Book book = new Book();
        book.SetName("Основи плвання");
        book.SetPrice(999);
        book.ApplyDiscount("70%");
        book.ApplyPromocode("SWIWBOY999");
        Console.WriteLine();

        Outerwear coat = new Outerwear();
        coat.SetName("Nike Puffer");
        coat.SetPrice(8900);
        coat.ApplyDiscount("35%");
        coat.ApplyPromocode("LoveNike999");
        coat.SetSize(42);
        coat.SetColor(4);

        Console.ReadKey();
    }
}