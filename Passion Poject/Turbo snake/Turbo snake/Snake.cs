using System;
using System.Threading;

namespace Turbo_snake
{
    class Snake
    {
        int Height = 25;
        int width = 50;

        int[] x = new int[25];
        int[] y = new int[100];

        int PelletX;
        int PelletY;

        int Parts = 4 ;
        int Score = 0 ;
        int multi = 5;



        ConsoleKeyInfo KeyInfo = new ConsoleKeyInfo();
        char keyw = 'w';

        Random random = new Random();




        Snake()
        {
            x[0] = 50;
            y[0] = 12;
            Console.CursorVisible = false;
        }
        public void cage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
          
            for (int i = 1; i <= (width + 2); i++)
            {
                Console.SetCursorPosition(i, ( Height + 0 ));
                Console.Write("_");
            }

            for (int i = 0; i <= (Height); i++)
            {
                Console.SetCursorPosition( (width + 3) , i );
                Console.Write("|");
            }
            Console.Write(Score);
        }
        public void Input()
        {
            if(Console.KeyAvailable)
            {
                KeyInfo = Console.ReadKey(true);
                keyw = KeyInfo.KeyChar;
            }
        }
        public void WritePoint(int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write("☼");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("██╗░░░██╗░█████╗░██╗░░░██╗  ██╗░░░░░░█████╗░░██████╗███████╗  ██╗  ██╗  ██╗");
                Console.WriteLine("╚██╗░██╔╝██╔══██╗██║░░░██║  ██║░░░░░██╔══██╗██╔════╝██╔════╝  ██║  ██║  ██║");
                Console.WriteLine("░╚████╔╝░██║░░██║██║░░░██║  ██║░░░░░██║░░██║╚█████╗░█████╗░░  ██║  ██║  ██║");
                Console.WriteLine("░░╚██╔╝░░██║░░██║██║░░░██║  ██║░░░░░██║░░██║░╚═══██╗██╔══╝░░  ╚═╝  ╚═╝  ╚═╝");
                Console.WriteLine("░░░██║░░░╚█████╔╝╚██████╔╝  ███████╗╚█████╔╝██████╔╝███████╗  ██╗  ██╗  ██╗");
                Console.WriteLine("░░░╚═╝░░░░╚════╝░░╚═════╝░  ╚══════╝░╚════╝░╚═════╝░╚══════╝  ╚═╝  ╚═╝  ╚═╝");
                Console.ReadKey();

            }
        }

        public void Logic()
        {
            if(x[0] == PelletX && y[0] == PelletY)
            {             
                    Parts++;
                    Score = (Parts - 4) * 10;                   
                    PelletX = random.Next(2,(width -2));
                    PelletY = random.Next(2,(Height-1)); 
            }
            for(int i = Parts; i > 1; i--)
            {
                try
                {
                    x[i - 1] = x[i - 2];
                    y[i - 1] = y[i - 2];
                }
                catch(IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("		─────────────────────░██░");
                    Console.WriteLine("		────────────────────░█▓▓█░");
                    Console.WriteLine("		───────────────────░█▓▓▓█░");
                    Console.WriteLine("		──────────────────░█▓▓▓▓▓█░");
                    Console.WriteLine("		─────────────────░█▓▓▓▓▓█░");
                    Console.WriteLine("		──────────░░░───░█▓▓▓▓▓▓█░");
                    Console.WriteLine("		─────────░███░──░█▓▓▓▓▓█░");
                    Console.WriteLine("		───────░██░░░██░█▓▓▓▓▓█░");
                    Console.WriteLine("		──────░█░░█░░░░██▓▓▓▓▓█░");
                    Console.WriteLine("		────░██░░█░░░░░░█▓▓▓▓█░");
                    Console.WriteLine("		───░█░░░█░░░░░░░██▓▓▓█░");
                    Console.WriteLine("		──░█░░░░█░░░░░░░░█▓▓▓█░");
                    Console.WriteLine("		──░█░░░░░█░░░░░░░░█▓▓▓█░");
                    Console.WriteLine("		──░█░░█░░░█░░░░░░░░█▓▓█░");
                    Console.WriteLine("		─░█░░░█░░░░██░░░░░░█▓▓█░");
                    Console.WriteLine("                ─░█░░░░█░░░░░██░░░█▓▓▓█░");
                    Console.WriteLine("    	        ─░█░█░░░█░░░░░░███▓▓▓▓█░");
                    Console.WriteLine("                ░█░░░█░░░██░░░░░█▓▓▓▓▓█░");
                    Console.WriteLine("		░█░░░░█░░░░█████▓▓▓▓▓█░");
                    Console.WriteLine("		░█░░░░░█░░░░░░░█▓▓▓▓▓█░");
                    Console.WriteLine("		░█░█░░░░██░░░░█▓▓▓▓▓█░");
                    Console.WriteLine("		─░█░█░░░░░████▓▓▓▓██░");
                    Console.WriteLine("		─░█░░█░░░░░░░█▓▓██▓█░");
                    Console.WriteLine("		──░█░░██░░░██▓▓█▓▓▓█░");
                    Console.WriteLine("		───░██░░███▓▓██▓█▓▓█░");
                    Console.WriteLine("		────░██▓▓▓███▓▓▓█▓▓▓█░");
                    Console.WriteLine("		──────░█▓▓▓▓▓▓▓▓█▓▓▓█░");
                    Console.WriteLine("		──────░█▓▓▓▓▓▓▓▓▓▓▓▓▓█░");
                    Console.WriteLine();

                    Console.WriteLine("██╗░░░██╗░█████╗░██╗░░░██╗  ░██╗░░░░░░░██╗██╗███╗░░██╗  ██╗  ██╗  ██╗");
                    Console.WriteLine("╚██╗░██╔╝██╔══██╗██║░░░██║  ░██║░░██╗░░██║██║████╗░██║  ██║  ██║  ██║");
                    Console.WriteLine("░╚████╔╝░██║░░██║██║░░░██║  ░╚██╗████╗██╔╝██║██╔██╗██║  ██║  ██║  ██║");
                    Console.WriteLine("░░╚██╔╝░░██║░░██║██║░░░██║  ░░████╔═████║░██║██║╚████║  ╚═╝  ╚═╝  ╚═╝");
                    Console.WriteLine("░░░██║░░░╚█████╔╝╚██████╔╝  ░░╚██╔╝░╚██╔╝░██║██║░╚███║  ██╗  ██╗  ██╗");
                    Console.WriteLine("░░░╚═╝░░░░╚════╝░░╚═════╝░  ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝  ╚═╝  ╚═╝  ╚═╝");
                    Console.ReadKey();

                }
            }
            switch(keyw)
            {
                case 'w':
                    y[0]--;
                    break;
                case 's':
                    y[0]++;
                    break;
                case 'd':
                    x[0]++;
                    break;
                case 'a':
                    x[0]--;
                    break;
            }
            for(int i= 0; i<= (Parts-1);i++)
            {
                WritePoint(x[i], y[i]);
                WritePoint(PelletX, PelletY);
            }
               Thread.Sleep(100);

        }
        static void Main(string[] args)
        {
            Snake Tsnake = new Snake();
            while (true)
            {
                Tsnake.cage();
                Tsnake.Input();
                Tsnake.Logic();
            }               
        }
    }
}
