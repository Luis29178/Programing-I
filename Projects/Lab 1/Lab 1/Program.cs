using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("██╗░░██╗███████╗██╗░░░░░██╗░░░░░░█████╗░░██╗░░░░░░░██╗");
            Console.WriteLine("██║░░██║██╔════╝██║░░░░░██║░░░░░██╔══██╗░██║░░██╗░░██║");
            Console.WriteLine("███████║█████╗░░██║░░░░░██║░░░░░██║░░██║░╚██╗████╗██╔╝");
            Console.WriteLine("██╔══██║██╔══╝░░██║░░░░░██║░░░░░██║░░██║░░████╔═████║░");
            Console.WriteLine("██║░░██║███████╗███████╗███████╗╚█████╔╝░░╚██╔╝░╚██╔╝░");
            Console.WriteLine("╚═╝░░╚═╝╚══════╝╚══════╝╚══════╝░╚════╝░░░░╚═╝░░░╚═╝░░");
            Console.WriteLine();
            Console.WriteLine("███████╗██╗░░░██╗██╗░░░░░██╗░░░░░░██████╗░█████╗░██╗██╗░░░░░██╗");
            Console.WriteLine("██╔════╝██║░░░██║██║░░░░░██║░░░░░██╔════╝██╔══██╗██║██║░░░░░██║");
            Console.WriteLine("█████╗░░██║░░░██║██║░░░░░██║░░░░░╚█████╗░███████║██║██║░░░░░██║");
            Console.WriteLine("██╔══╝░░██║░░░██║██║░░░░░██║░░░░░░╚═══██╗██╔══██║██║██║░░░░░╚═╝");
            Console.WriteLine("██║░░░░░╚██████╔╝███████╗███████╗██████╔╝██║░░██║██║███████╗██╗");
            Console.WriteLine("\n\n\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();





            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It is verry nice to meet you " + name + "!");
            Console.WriteLine("\n\n\nPress any key to continue . . . ");
            Console.ReadKey();
            Console.Clear();





            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("cCongrotulatins for you " + age + " well lets hope many more aswell!");
            Console.WriteLine("\n\n\nPress any key to continue . . . ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Well, it was nice talking to you goodbye.");
            Console.WriteLine("\n\n\nPress any key to exit . . . ");
            Console.ReadKey();
        }

    }
}
