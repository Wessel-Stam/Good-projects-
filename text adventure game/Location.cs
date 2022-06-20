using System;
using System.Collections.Generic;
using System.Text;

namespace DefeatTheLeerplichtAmbtenaar
{
    public class Location
    {

        public string Name { get; set; }
        public string Weather { get; set; }
        public string Area { get; set; }

        public bool CaveAccess { get; set; }
        public bool CastleAccess { get; set; }


        public Location(string name, string area, string weather , bool caveaccess, bool castleAccess)
        {
            Weather = weather;
            Area = area;
            Name = name;
            CaveAccess = caveaccess;
            CastleAccess = castleAccess;
        }
        public string Describe()
        {
            string description = Name;
            return description;
        }

    }
}

