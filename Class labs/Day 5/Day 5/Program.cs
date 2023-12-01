using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Player
    {
        int health;
        int armor;
        string playerName;
        Random rand;

        public Player(Random randomValue)
        {
            rand = randomValue;
        }

        public void InitializePlayer(string nameValue, int healthValue, int armorValue)
        {
            playerName = nameValue;
            health = healthValue;
            armor = armorValue;
        }

        //Setter
        public void SetPlayerName(string value)
        {
            playerName = value;
        }

        public void SetHealth(int value)
        {
            health = value;
        }

        public void SetArmor(int value)
        {
            armor = value;
        }

        public void Damage(int damage)
        {
            Console.WriteLine("Health before damage:" + health);
            //limit raw damage to 1000
            if (damage > 1000)
            {
                damage = 1000;
            }

            //damage mitigation due to armor
            int reducedDamage = damage - armor;

            //prevent healing from negative damage
            if (reducedDamage < 0)
            {
                reducedDamage = 0;
            }

            Console.WriteLine("Damage done: " + reducedDamage);

            health = health - reducedDamage;

            //never have negative health
            if (health < 0)
                health = 0;

            Console.WriteLine("Health after damage:" + health);
        }

        public void PrintStats()
        {
            Console.WriteLine("Player: " + playerName);
            Console.WriteLine("Health:" + health);
            Console.WriteLine("Armor:" + armor);
        }

        public void PrintName()
        {
            Console.WriteLine("Player: " + playerName);
        }

        public string GenerateRandomName()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            //random length of characters 4-8
            //random characters themselves

            //generate random length
            int length = rand.Next(4, 8);
            char[] stringChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                //Grab a random character from the char array
                stringChars[i] = chars[rand.Next(0, chars.Length)];
            }

            //convert character array into a string
            return new string(stringChars);

        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Player[] players = new Player[1000];

            //Initialize the players!
            for(int i = 0; i < players.Length; i++)
            {
                //Create a new player class
                players[i] = new Player(rand);

                //Fill in the player details
                players[i].InitializePlayer(players[i].GenerateRandomName(), rand.Next(50, 100), rand.Next(10, 80));

                players[i].PrintStats();
            }


            //Player player1 = new Player();
            //player1.InitializePlayer("billY", 100, 100);
            //player1.PrintStats();

            //player1.Damage(150);

            //Player player2 = new Player();
            //player2.InitializePlayer("Jaco-b", 50, 200);
            //player1.PrintStats();
            //player2.Damage(50);

            Console.ReadLine();
        }
    }
}
