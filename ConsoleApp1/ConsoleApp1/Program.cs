using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till ett spel där du gissar nummer?");
            Random randomerare = new Random();
            int f = 0;
            int randomtal = randomerare.Next(1, 100);
            Console.WriteLine("Gissa på ett tal mellan 1 och 100");
            string str = Console.ReadLine();
            int tal = Convert.ToInt32(str);

            while (randomtal != tal)
            {
                f++;
                Console.WriteLine("Fel gissa igen!");
                
                if (tal > randomtal)
                {
                    Console.WriteLine("Talet är mindre");
                }
                else if (tal < randomtal)
                {
                    Console.WriteLine("Talet är större");
                }
                str = Console.ReadLine();
                tal = Convert.ToInt32(str);
            }
            
            Console.WriteLine("Grattis du gissade rätt");
            Console.WriteLine("Du fick rätt efter " + f + " försök");
            Console.ReadLine();
        }
    }
}
