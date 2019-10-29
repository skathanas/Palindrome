using System;
using System.Linq;

namespace Palindrome
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Teretulemast palindroomi programmi");
            Console.WriteLine("Palun kirjuta oma nimi:");
            var original = Console.ReadLine();
            var reversed = new string(original.Reverse().ToArray());
            if (original == reversed) {
                Console.WriteLine("Teie nimi tagurpidi on " + reversed + ". Ning tegu on palindroomiga");
            }
            else
            { Console.WriteLine("Teie nimi tagurpidi on " + reversed + ". Ning tegu pole palindroomiga");
            }
        }
    }
}
