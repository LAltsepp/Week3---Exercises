using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis temperatuur on õues?");
            int Weather = Convert.ToInt32(Console.ReadLine());
            if (Weather >= 35)
            {
                Console.WriteLine("Boiling hot");
            }
            else if (Weather >= 30 && Weather < 35)
            {
                Console.WriteLine("Hot");
            }
            else if (Weather >= 20 && Weather < 30)
            {
                Console.WriteLine("Nice");
            }
            else if (Weather >= 10 && Weather < 20)
            {
                Console.WriteLine("Chilly");
            }
            else if (Weather >=0 && Weather < 10)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("Very cold");
            }


        }
    }
}
