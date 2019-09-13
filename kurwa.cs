using System;

class Program
{
    static void Main(string[] args)
    {
        bool Done = false;
        string imie;

        while (Done == false)
        {
            Console.WriteLine("Podaj kobiete");
            imie = Console.WriteLine();

            if (imie[imie.Length - 1] == 'a') ;
            {
                Done = true;
                Console.WriteLine("czesc +name");

            }
            else
            {
                Console.WriteLine("dales meskie");
            }
        }
        Console.Read();
    }
}