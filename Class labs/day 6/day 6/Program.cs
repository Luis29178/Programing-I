using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;
using System.Threading;

namespace Day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            Player player = new Player();
            Console.CursorVisible = false;
            
            //Create random out here and pass it to the enemy so that
            //the seed is the same and produces different random numbers
            Random random = new Random();
            Enemy[] enemies = new Enemy[100];

            //Initialize the enemies
            for(int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new Enemy(random);
            }

            //Give the player a copy of the enemies
            player.SetEnemies(enemies);

            //Game loop
            while(true)
            {
                //Slow down the frames per second
                Thread.Sleep(100);

                //input and update
                player.Update();

                //Update all the enemies
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].Update();
                }

                //Clear the console
                Console.Clear();

                //Draw all the enemies
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].Draw();
                }

                //draw
                player.Draw();
            }
        }
    }
}
