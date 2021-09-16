using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //kui sisustatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti."

            Console.WriteLine("Sisesta oma PIN-kood.");
            int userPin = Convert.ToInt32(Console.ReadLine());
            
            /*if (userPin == 1234)
                
            {
                Console.WriteLine("Tere tulemast.");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }*/

            if(userPin != 1234)
            {
                Console.WriteLine("Vale PIN");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

        }
    }
}
