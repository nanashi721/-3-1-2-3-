using System;

class Parallelogram
{
    private double sideA, sideB, angleDegrees;

    public Parallelogram(double sideA, double sideB, double angleDegrees)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.angleDegrees = angleDegrees;
    }

    public double GetPerimeter()
    {
        return 2 * (sideA + sideB);
    }

    public double GetArea()
    {
        double radians = angleDegrees * Math.PI / 180.0;
        return sideA * sideB * Math.Sin(radians);
    }

    public double GetDiagonal()
    {
        double radians = angleDegrees * Math.PI / 180.0;
        return Math.Sqrt(sideA * sideA + sideB * sideB - 2 * sideA * sideB * Math.Cos(radians));
    }
}

class Program
{
    static void Main()
    {
        Parallelogram parallelogram = new Parallelogram(5, 3, 60);

        Console.WriteLine("Периметр паралелограма: " + parallelogram.GetPerimeter());
        Console.WriteLine("Площа паралелограма: " + parallelogram.GetArea());
        Console.WriteLine("Довжина діагоналі: " + parallelogram.GetDiagonal());

        Console.ReadLine();
}