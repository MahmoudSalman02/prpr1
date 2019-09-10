using System;

namespace ConsoleApp1
{
    class Program
    {
    using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till ett spel där du gissar nummer?");
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 100);
            Console.WriteLine("Gissa på ett tal mellan 1 och 101");
            string str = Console.ReadLine();
            int tal = Convert.ToInt32(str);

            do
            {
                Console.WriteLine("Fel gissa igen!");
                str = Console.ReadLine();
                tal = Convert.ToInt32(str);
                if (tal > slump_tal)
                {
                    Console.WriteLine("Talet är mindre");
                }
                else if (tal < slump_tal)
                {
                    Console.WriteLine("Talet är större");
                }

            }
            while (tal != slump_tal);
            Console.WriteLine("Grattis du gissade rätt");
            Console.ReadLine();
