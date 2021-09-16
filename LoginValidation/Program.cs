using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmed
            //kui sisestatud kasutaja tunnus on "admin" ja
            //sisestatud parool on "admin1234"
            //siis programm kuvab "Tere tulemast!"
            //muul juhul programm kuvab "Vale kasutaja tunnus või parool. Proovi uuesti";

            Console.WriteLine("Sisestage kasutajatunnus");
            

            string UserName = Console.ReadLine();
            string password = Console.ReadLine();
            

            if (UserName != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnu või parool");
            }
            else 
            {
                Console.WriteLine("Kasutajatunnus ja parool on õige, tere tulemast");
            }

        }
    }
}
