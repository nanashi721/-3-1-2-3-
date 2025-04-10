using System;

class Product
{
    private double pricePerUnit;
    private int quantity;

    public Product(double pricePerUnit, int quantity)
    {
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public string GetInfo()
    {
        return $"Ціна за одиницю: {pricePerUnit} грн, Кількість: {quantity}";
    }

    public double CalculateTotalCost()
    {
        return pricePerUnit * quantity;
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product(45.50, 3);
        Console.WriteLine(product.GetInfo());
        Console.WriteLine("Загальна вартість товару: " + product.CalculateTotalCost() + " грн");
    }
}
