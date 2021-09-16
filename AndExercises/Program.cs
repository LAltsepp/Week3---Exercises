using System;

namespace AndExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //sabba arstiks õppida

            Console.WriteLine("Sisesta oma eksami punktid matemaatikas, keemias ja bioloogias");
            Console.WriteLine("Sisesta matemaatika eksami punktid");
            int math = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Sisesta keemia eksami punktid");
            int chem = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Sisesta bioloogia eksami punktid");
            int bio = Convert.ToInt32(Console.ReadLine());
         

            if (math >= 85 && chem >= 90 && bio >= 95)
            {
                Console.WriteLine("Sul on piisavalt punkte");
            }
            else
            {
                Console.WriteLine("Sul pole piisavalt punkte");
            }

        }
    }
}
