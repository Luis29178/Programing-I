using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;

namespace Day_6
{
    class Enemy
    {
        int x, y;
        char avatar;
        char dead;
        bool isAlive;
        Random random;

        public Enemy(Random random)
        {
            this.random = random;
            isAlive = true;

            x = random.Next(0, Console.WindowWidth - 1);
            y = random.Next(0, Console.WindowHeight - 1);

            avatar = 'E';
            dead = 'X';
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void Die()
        {
            isAlive = false;
        }

        public void Update()
        {
            if(isAlive)
            {
                //Pick random direction
                switch (random.Next(0, 4))
                {
                    case 0:
                        x--;
                        break;
                    case 1:
                        x++;
                        break;
                    case 2:
                        y--;
                        break;
                    case 3:
                        y++;
                        break;
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

            //draw the correct character based on if the enemy is dead or alive
            if(isAlive)
                Console.Write(avatar);
            else
                Console.Write(dead);
        }
    }
}
