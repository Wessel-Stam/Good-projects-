using System;
using System.Collections.Generic;
using System.Text;

namespace DefeatTheLeerplichtAmbtenaar
{
    class Player
    {
        public static string command = "";
        public static Items items = new Items();
        public Inventory inventory;
        public static Bossfight bossfight = new Bossfight();
        private static Grid adventureMap = new Grid();
        public static int posx = 5;
        public static int posy = 5;
        public Player()
        {
            adventureMap.MakeGrid();
        }
        public void Movement()
        {
            do
            {
                Console.WriteLine(adventureMap.GridMap[posx, posy].Describe() + posx + posy);
                command = Console.ReadLine();
                inventory.ShowInventory(command);
                items.ItemPickup();
                inventory.MakeInventory();
                inventory.ItemDrop(command);
                BossFightCheck();
                if (command == "west")
                {
                    if (posx > 0)
                    {
                        posx = posx - 1;

                        if (adventureMap.GridMap[posx, posy].CaveAccess == false && !items.torchInventoryBool && adventureMap.GridMap[posx, posy].Area == "cave")
                        {
                            Console.WriteLine("You can't go in here");
                            posx = posx + 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you can't go here");
                    }
                }
                else if (command == "east")
                {
                    if (posx < 9)
                    {
                        posx = posx + 1;
                        if (adventureMap.GridMap[posx, posy].CaveAccess == false && !items.torchInventoryBool && adventureMap.GridMap[posx, posy].Area == "cave")
                        {
                            Console.WriteLine("You can't go in here");
                            posx = posx - 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you can't go here");
                    }
                }
                else if (command == "south")
                {
                    if (posy < 9)
                    {
                        posy = posy + 1;
                        if (adventureMap.GridMap[posx, posy].CaveAccess == false && !items.torchInventoryBool && adventureMap.GridMap[posx, posy].Area == "cave")
                        {
                            Console.WriteLine("You can't go in here");
                            posy = posy - 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you can't go here");
                    }
                }
                else if (command == "north")
                {
                    if (posy > 0)
                    {
                        posy = posy - 1;
                        if (adventureMap.GridMap[posx, posy].CaveAccess == false && !items.torchInventoryBool && adventureMap.GridMap[posx, posy].Area == "cave")
                        {
                            Console.WriteLine("You can't go in here");
                            posy = posy + 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you can't go here");
                    }
                }

            } while (command != "quit");
        }

        public static void BossFightCheck()
        {
            int bossX = 5;
            int bossY = 0;
            if (posx == bossX && posy == bossY)
            {
                Bossfight.BossFight();
            }

        }
    }
}
