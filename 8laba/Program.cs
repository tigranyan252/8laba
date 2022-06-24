using System;
using System.IO;
using System.Linq;

namespace _8laba
{
    class Program
    {

        static bool IsPalindrome(string str)
        {
            return str == new string(str.Reverse().ToArray());
        }

        static void Main()
        {
            const string filePath = "result.txt";
            Console.Write("Введите строку: ");
            var str = Console.ReadLine();
            var result = IsPalindrome(str);
            var message = "Строка '" + str + "' является палиндромом: " + result;

            Console.WriteLine(message);
            File.WriteAllText(filePath, message);

            Console.ReadKey();

        }
    }
}
