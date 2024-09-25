using ReversedNumber.Models;

namespace ReversedNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int number = int.Parse(Console.ReadLine());

            int reverseNumber = Reverse.ReverseNumber(number);

            Console.WriteLine($"The reverse number of entered number is {reverseNumber}");
        }
    }
}
