using System;
using System.Collections.Generic;
using System.Text;

namespace DefeatTheLeerplichtAmbtenaar
{
    class Inventory : Items
    {
        public static Dictionary<int, string> ItemList;
        public static Grid adventureMap = new Grid();
        public Items items;


        public void ShowInventory(string command)
        {
            MakeInventory();
            switch (command)
            {
                case "Inventory":
                case "inventory":
                case "Show inventory":
                case "show inventory":
                case "inv":
                    foreach (var item in ItemList)
                    {
                        Console.Write(item + ", ");
                    }
                    break;
            }
        }

        public void MakeInventory()
        {
            ItemList = new Dictionary<int, string>();
            // bool to determine if its in the inventory
            if (items.torchInventoryBool == true)
            {
                if (ItemList.ContainsValue("1"))
                {

                }
                else
                {
                    int number = 1;
                    string item = "Torch";
                    ItemList.Add(number, item);
                }
            }

            if (items.keyForestInventoryBool == true)
            {
                if (ItemList.ContainsValue("2"))
                {

                }
                else
                {
                    int number = 2;
                    string item = "Forest key";
                    ItemList.Add(number, item);
                }
            }

            if (items.keyCaveInventoryBool == true)
            {
                if (ItemList.ContainsValue("3"))
                {

                }
                else

                {
                    int number = 3;
                    string item = "Cave key";
                    ItemList.Add(number, item);
                }
            }

            if (items.swordInventoryBool == true)
            {
                if (ItemList.ContainsValue("4"))
                {

                }
                else
                {
                    int number = 4;
                    string item = "Sword";
                    ItemList.Add(number, item);
                }
            }

            if (items.shieldInventoryBool == true)
            {
                if (ItemList.ContainsValue("5"))
                {

                }
                else
                {
                    int number = 5;
                    string item = "Shield";
                    ItemList.Add(number, item);
                }
            }
        }

        public void ItemDrop(string command)
        {
            switch (command)
            {
                case "Drop golden key":
                case "drop golden key":
                    {
                        items.keyForestInventoryBool = false;
                        items.keyForestGroundBool = true;
                        ItemList.Remove(2);
                        break;
                    }



                case "Drop silver key":
                case "drop silver key":
                    {
                        items.keyCaveInventoryBool = false;
                        items.keyCaveGroundBool = true;
                        ItemList.Remove(3);
                        break;
                    }



                case "Drop sword":
                case "drop sword":
                    {
                        items.swordInventoryBool = false;
                        items.swordGroundBool = true;
                        ItemList.Remove(4);
                        break;
                    }


                case "Drop shield":
                case "drop shield":
                    {
                        items.shieldInventoryBool = false;
                        items.shieldGroundBool = true;

                        ItemList.Remove(5);
                        break;
                    }


                case "Drop torch":
                case "drop torch":
                    {
                        items.torchInventoryBool = false;
                        items.torchGroundBool = true;
                        ItemList.Remove(1);
                        break;
                    }
            }
        }
    }
}
