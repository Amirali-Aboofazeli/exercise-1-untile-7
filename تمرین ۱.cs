> Amirali Aboofazeli:
using System;

class Program
{
    static void Main()
    {
        Console.Write("عدد اول (m) را وارد کنید: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("عدد دوم (n) را وارد کنید: ");
        int n = int.Parse(Console.ReadLine());
        
        if (m > n)
        {
            int temp = m;
            m = n;
            n = temp;
        }

        Console.WriteLine($"اعداد اول بین {m} و {n}:");
        for (int i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}