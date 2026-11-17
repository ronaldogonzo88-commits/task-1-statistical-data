using System;
class StatisticalData
{
    private int num1, num2, num3;
    public void Set(int a, int b, int c)
    {
        num1 = a;
        num2 = b;
        num3 = c;
    }
    public int Largest()
    {
        return Math.Max(num1, Math.Max(num2, num3));
    }
    public int Smallest()
    {
        return Math.Min(num1, Math.Min(num2, num3));
    }
    public double Average()
    {
        return (num1 + num2 + num3) / 3.0;
    }

    class Program
    {
        static void Main()
        {
            StatisticalData[] data = new StatisticalData[5];
            for (int i = 0; i < 5; i++)
            {
                data[i] = new StatisticalData();

                Console.Write("Enter 3 numbers: ");

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                data[i].Set(a, b, c);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Largest " + data[i].Largest());
                Console.WriteLine("Smallest " + data[i].Smallest());
                Console.WriteLine("Average " + data[i].Average());
            }
        }
    }
}