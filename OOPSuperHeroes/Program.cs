﻿using System;

namespace OOPSuperHeroes
{
    class Program
    {
        class Player
        {
            string name;
            int hp;

            //constructor
            public Player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 101);
            }

            public void SayHello()
            {
                Console.WriteLine($"{name} says Hello!");
            }

            public void ShowYourHP()
            {
                Console.WriteLine($"{name}'s HP: {hp}");
            }

            public int MakeDamage()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            }

            public void TakeDamage(int damage)
            {
                if (hp <= 0)
                {
                    hp = 0;
                }
                else
                {
                    hp = hp - damage;
                }

            }

            public int HP
            {
                get { return hp; }
            }

            public string Name
            {
                get { return name; }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Player one name: ");
                string characterName = Console.ReadLine();
                Console.WriteLine("Player two name: ");
                string characterNameTwo = Console.ReadLine();

                Player playerOne = new Player(characterName);
                Player playerTwo = new Player(characterNameTwo);
                playerOne.SayHello();
                playerOne.ShowYourHP();

                playerTwo.SayHello();
                playerTwo.ShowYourHP();

                for (int i = 0; i < 3; i++)
                {
                    playerOne.TakeDamage(playerTwo.MakeDamage());
                    playerTwo.TakeDamage(playerOne.MakeDamage());
                    playerOne.ShowYourHP();
                    playerTwo.ShowYourHP();
                }

                if (playerOne.HP > playerTwo.HP)
                {
                    Console.WriteLine($"{playerOne.Name} wins!");
                }
                else if (playerOne.HP < playerTwo.HP)
                {
                    Console.WriteLine($"{playerTwo.Name} wins!");
                }


            }
        }
    }
}
