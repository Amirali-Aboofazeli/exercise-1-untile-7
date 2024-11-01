> Amirali Aboofazeli:
using System;

class Program
{
    static void Main()
    {
        Console.Write("عدد m را وارد کنید: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("عدد n را وارد کنید: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (m > n)
        {
            int temp = m;
            m = n;
            n = temp;
        }

        Console.WriteLine("اعداد آینه‌ای بین {0} و {1}:", m, n);
        for (int i = m; i <= n; i++)
        {
            if (IsPalindromeNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    
    static bool IsPalindromeNumber(int number)
    {
        string original = number.ToString();
        char[] reversedArray = original.ToCharArray();
        Array.Reverse(reversedArray);
        string reversed = new string(reversedArray);

        return original == reversed;
    }
}
