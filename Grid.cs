using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DefeatTheLeerplichtAmbtenaar
{
    public class Grid    
    {
        public string name;
        public string weather;
        public string type;

        public Location[,] GridMap { get; set; }

        public void MakeGrid()
        {
            string[] lines = File.ReadAllLines("grid.txt");
            GridMap = new Location[10,10];
            bool caveEntrance = false;
            bool castleEntrance = false;
               
                int x = 0;
                int y = 0;

            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var parts = line.Split(',');
                var acces = parts[0];
                var name = parts[1];
                var type = parts[2];
                var weather = parts[3];
                if(acces == "C" && type == "cave")
                {
                    caveEntrance = false;
                }
                else if(type == "cave")
                {
                    caveEntrance = true;
                }
                if (acces == "Z" && type == "kasteel")
                {
                    castleEntrance = false;
                }
                else if(type == "kasteel")
                {
                    castleEntrance = true;
                }
                var location = new Location(name, type, weather, caveEntrance, castleEntrance);
                

                GridMap[x,y] = location;


                x++;
                
                if ( x>=10)
                {
                    x = 0;
                    y++;
                }
           }
        }
    }
}
