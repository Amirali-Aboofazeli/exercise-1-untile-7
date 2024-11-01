> Amirali Aboofazeli:
using System;

class Program
{
    static void Main()
    {
        Console.Write("لطفاً عدد n را وارد کنید: ");
        int n = int.Parse(Console.ReadLine());

        if (IsFibonacci(n))
        {
            Console.WriteLine($"{n} در سری فیبوناچی وجود دارد.");
        }
        else
        {
            Console.WriteLine($"{n} در سری فیبوناچی وجود ندارد.");
        }
    }

    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1;

        if (n == a || n == b)
            return true;

        int c = a + b;
        while (c <= n)
        {
            if (c == n)
                return true;

            a = b;
            b = c;
            c = a + b;
        }

        return false;
    }
}
