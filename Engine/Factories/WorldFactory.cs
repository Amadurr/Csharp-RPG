using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, -1, "Home",
                "This is your home", 
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-1, -1, "Forests of Syltharin",
                "The forests are dense with trees",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-2, -1, "Lisryggad",
                "A beautiful forest city created by the Thylvari",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-2, -2, "Fields of Tholstrid",
                "Vast fields with farmers",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-2, 0, "Marshes of the Enarrh-Khirss",
                "The forests are dense with trees",
                "/Engine;component/Images/Locations/125x125.png");

            return newWorld;
        }
    }
}
