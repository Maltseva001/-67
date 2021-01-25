using System;

class Wildlixer
{

    private double side1, side2, side3, height, katet;
    public Wildlixer()
    {
        Console.WriteLine("Неизвестны параметры трапеции");
    }
    public Wildlixer(double s1, double s2, double h)
    {
        side1 = s1;
        side2 = s2;
        height = h;
        katet = (side1 - side2) / 2;

    }
    public double GetPerim()
    {
        side3 = Math.Sqrt(Math.Pow(katet, 2) + Math.Pow(height, 2));
        return side1 + side2 + side3 * 2;
    }
}

class MyClass
{
    public static void Main(String[] args)
    {
        Wildlixer Trap1 = new Wildlixer(50, 30, 12);
        Wildlixer Trap2 = new Wildlixer(20, 60, 25);

        Console.WriteLine("Сумма периметров двух трапеций равна {0:#.##}", (Trap1.GetPerim() + Trap2.GetPerim()));
        Console.ReadLine();
    }
}