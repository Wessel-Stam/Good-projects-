using System;

namespace DefeatTheLeerplichtAmbtenaar
{
    class Program
    {
        //Location[,] GridMap = new Location[10, 10];
        private static Grid adventureMap = new Grid();
        public static int posx = 5;
        public static int posy = 5;
        public static Items items = new Items();
        public static Inventory inventory = new Inventory();
        public static Bossfight bossfight = new Bossfight();
        public static Player player = new Player();
        static void Main(string[] args)
        {
            inventory.items = items;
            player.inventory = inventory;
            Readworld();
            Startgame();
        }

        private static void Readworld()
        {
            adventureMap.MakeGrid();

        }

        public static void Startgame()
        {
            bool tutorialBool = true;
            string playerName;
            Console.WriteLine("Welcome to the game");
            Console.WriteLine("Press 'Enter' to start");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You wake up in the middle of nowhere, standing over you is a blonde guy. 'Hello adventurer! My name is Wessel Stam! What is your name?'");
            do
            {
                Console.Write("Enter your name: ");
                playerName = Console.ReadLine();
                if (String.IsNullOrEmpty(playerName))
                {
                    Console.WriteLine("'Dude, that's not a damn name. What's your name?'");
                }
                else
                {
                    tutorialBool = false;
                }

            } while (tutorialBool == true);
            Console.WriteLine($"You sound pretty pog {playerName}. I got this chest which contains mysterious treasure! Could you find me the key?'");
            do
            {
                Console.WriteLine("What do you say?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("Choice: ");
                string choice = Console.ReadLine().ToLower();
                Console.Clear();

                tutorialBool = true;
                switch (choice)
                {
                    case "1":
                    case "Yes":
                    case "yes":
                        {
                            Console.WriteLine("'Thank you adventurer! There is one key in the west at the mine, there is one key in the forest at the east. You need    both of them before getting the last key in the castle up north. Use the pickup command to pick items up, use the      inventory command to look into your inventory, use the look command to look around and you and use north, west, south   and east to move around the map.. Goodluck! Here, don't forget this.' You gain a sword and shield");
                            tutorialBool = false;
                            break;
                        }
                    case "2":
                    case "No":
                    case "no":
                        {
                            break;
                        }
                }
            } while (tutorialBool == true);

            do
            {
                player.Movement();
            } while (Player.command != "quit");
        }
    }
}