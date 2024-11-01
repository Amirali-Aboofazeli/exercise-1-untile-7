> Amirali Aboofazeli:
using System;

class Program
{
    static void Main()
    {
        int number;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("لطفاً یک عدد وارد کنید: ");
            string input = Console.ReadLine();

            isValid = int.TryParse(input, out number);

            if (!isValid)
            {
                Console.WriteLine("ورودی نامعتبر است. لطفاً یک عدد صحیح وارد کنید.");
            }
        }

        Console.WriteLine($"شما عدد {number} را وارد کردید.");
    }
}
