> Amirali Aboofazeli:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("لطفاً کاراکتر وارد کنید (برای خروج از برنامه، Enter را فشار دهید):");

        while (true)
        {
            
            string input = Console.ReadLine();

          
            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            if (input.Length == 1 && char.IsLetter(input[0]))
            {
                Console.WriteLine($"شما کاراکتر '{input[0]}' را وارد کردید.");
            }
            else
            {
                Console.WriteLine("لطفاً فقط یک کاراکتر حرف وارد کنید.");
            }
        }

        Console.WriteLine("برنامه به پایان رسید.");
    }
}
