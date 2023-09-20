using System;
namespace inlämningsuppgift_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Alma?");
            string Alma=Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Elin?");
            string Elin = Console.ReadLine();
            int Almas=int.Parse(Alma);
            int Elins=int.Parse(Elin);
            int Skillnad = Elins - Almas;
            Console.WriteLine("Skillnaden är " + Skillnad + "cm");

        }
    }
}

