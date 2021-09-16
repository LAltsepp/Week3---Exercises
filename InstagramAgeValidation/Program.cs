using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat noorem
            //kui kasutaja on 13 aasta vana või vanem
            //siis ta võib Instagram`i kasutada
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor

            Console.WriteLine("Misaastal sa sündisid?");
            int userYearOfBirth = Conver.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Kui vana sa oled?");
            int UserAge = 2021 - userYearOfBirth;
            if (UserAge >= 13)
            {
                Console.WriteLine("Sa võid instagrami kasutada");

            }
            else
            {
                Console.WriteLine("Sa ei või seda kasutada instagrammi");
            }
        }
    }
}
