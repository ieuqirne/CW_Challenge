using System;
using CodingChallenge.ReversingString;
namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var varia = StringUtilities.Reverse("Hello World!");
            Console.WriteLine(varia);
        }
    }
}
