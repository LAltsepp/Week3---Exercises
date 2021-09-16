using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht:");
            char userCharacter = Convert.ToChar(Console.ReadLine().ToLower());
            switch (userCharacter)

            {
                case 'a':
                    Console.WriteLine("See täht on täishäälik");
                    break;

                case 'e':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'õ':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'ä':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'ö':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'ü':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                default:
                    Console.WriteLine("See on kaashäälik");
                    break;

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
