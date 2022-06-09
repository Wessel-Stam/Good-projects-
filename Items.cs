
using System;
using System.Collections.Generic;
namespace DefeatTheLeerplichtAmbtenaar
{
    class Items
    {

        public int keyCaveLocationX = 5;
        public int keyCaveLocationY = 2;
        public int keyForestLocationX = 9;
        public int keyForestLocationY = 6;
        public int swordLocationX = 5;
        public int swordLocationY = 5;
        public int shieldLocationX = 5;
        public int shieldLocationY = 5;
        public int torchLocationX = 3;
        public int torchLocationY = 5;

        // Bool made for checking if item is in inventory (true is in inventory)
        public bool keyCaveInventoryBool = false;
        public bool keyForestInventoryBool = false;
        public bool swordInventoryBool = true;
        public bool shieldInventoryBool = true;
        public bool torchInventoryBool = false;

        // Bool made for checking if the item is still on the ground (true is still on the ground)
        public bool keyCaveGroundBool = true;
        public bool keyForestGroundBool = true;
        public bool swordGroundBool = false;
        public bool shieldGroundBool = false;
        public bool torchGroundBool = true;

        public void ItemPickup()
        {
            // checking for player input to match with item location for inventory system
            if (Player.posy == keyCaveLocationY && Player.posx == keyCaveLocationX)
            {
                switch (Player.command)
                {
                    case "Pickup golden key":
                    case "pickup key":
                    case "pickup":
                    case "Pickup key":
                        {
                            keyCaveInventoryBool = true;
                            keyCaveGroundBool = false;
                            break;
                        }
                }
            }

            if ( Player.posy == keyForestLocationY && Player.posx == keyForestLocationX)
            {


                switch (Player.command)
                {

                    case "Pickup  silver key":
                    case "pickup  silver key":
                    case "pickup key":
                    case "Pickup key":
                        {
                            keyForestInventoryBool = true;
                            keyCaveGroundBool = false;
                            break;
                        }
                }
            }

            if (Player.posy == swordLocationY && Player.posx == swordLocationX)
            {
                switch (Player.command)
                {
                    case "Pickup sword":
                    case "pickup sword":
                        {
                            swordInventoryBool = true;
                            swordGroundBool = false;
                            break;
                        }
                }
            }
            if (Player.posy == shieldLocationY && Player.posx == shieldLocationX)
            {
                switch (Player.command)
                {
                    case "Pickup shield":
                    case "pickup shield":
                        {
                            shieldInventoryBool = true;
                            shieldGroundBool = false;
                            break;
                        }
                }
            }
            if (Player.posy == torchLocationY && Player.posx == torchLocationX)
            {
                switch (Player.command)
                {
                    case "Pickup torch":
                    case "pickup torch":
                    case "pickup":
                    case "Pickup":
                        {
                            Console.WriteLine("pickup werkt");
                            torchInventoryBool = true;
                            torchGroundBool = false;
                            break;
                        }
                }
            }
        }

        
    }
}
