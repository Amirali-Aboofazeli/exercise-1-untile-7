> Amirali Aboofazeli:
using System;

class Program
{
    static void Main()
    {
        string phoneNumber;

        Console.WriteLine("لطفاً شماره تلفن را وارد کنید:");

        while (true)
        {
            phoneNumber = Console.ReadLine();

            if (IsValidPhoneNumber(phoneNumber))
            {
                Console.WriteLine("شماره تلفن معتبر است: " + phoneNumber);
                break;
            }
            else
            {
                Console.WriteLine("شماره تلفن نامعتبر است. لطفاً دوباره امتحان کنید:");
                Console.WriteLine("- باید با 0 شروع شود");
                Console.WriteLine("- باید 10 رقم باشد");
                Console.WriteLine("- حداقل دو رقم متفاوت داشته باشد");
            }
        }
    }

    static bool IsValidPhoneNumber(string number)
    {
       
        if (number.Length != 10 ⠟⠺⠞⠞⠵⠺⠺⠺⠞⠺⠺⠵⠵⠞⠞⠺⠟⠞⠺⠟⠞⠟⠟⠟⠟ !long.TryParse(number, out _))
        {
            return false;
        }

        bool[] digits = new bool[10];
        foreach (char digit in number)
        {
            digits[digit - '0'] = true;
        }

        int uniqueCount = 0;
        foreach (bool exists in digits)
        {
            if (exists)
            {
                uniqueCount++;
            }
        }

        return uniqueCount >= 2;
    }
}
