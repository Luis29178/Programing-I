using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;

namespace Day_6
{
    class Player
    {
        int x, y;
        char avatar;
        Enemy[] enemies;

        public void SetEnemies(Enemy[] enemies)
        {
            this.enemies = enemies;
        }

        public Player()
        {
            x = Console.WindowWidth / 2;
            y = Console.WindowHeight / 2;
            avatar = '@';
        }

        public void Update()
        {
            //Input - make the player move
            if (Utility.GetKeyState(ConsoleKey.LeftArrow))
            {
                x--;
            }

            if (Utility.GetKeyState(ConsoleKey.RightArrow))
            {
                x++;
            }

            if (Utility.GetKeyState(ConsoleKey.UpArrow))
            {
                y--;
            }

            if (Utility.GetKeyState(ConsoleKey.DownArrow))
            {
                y++;
            }

            if(enemies != null)
            {
                //foreach example
                foreach (Enemy enemy in enemies)
                {
                    //if this is true, then we killed the enemy
                    if (enemy.GetX() == x && enemy.GetY() == y)
                    {
                        enemy.Die();
                    }
                }
            }
            
            //Bounds - make sure the player does not go beyond the screen
            if (x < 0)
                x = 0;

            if (x > Console.WindowWidth - 1)
                x = Console.WindowWidth - 1;

            if (y < 0)
                y = 0;

            if (y > Console.WindowHeight - 1)
                y = Console.WindowHeight - 1;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(avatar);
        }

    }
}
