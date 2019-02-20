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


            // TODO: Fix the X and Y Coordinate ordering. 

            newWorld.AddLocation(0, -1, "Home",
                "This is your home", 
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-1, -1, "Forests of Syltharin 1-1",
                "The forests are dense with trees",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-2, -1, "Forests of Syltharin 2-1",
                "A beautiful forest city created by the Thylvari",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-3, -1, "Forests of Syltharin 3-1",
                "A beautiful forest city created by the Thylvari",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-1, -2, "Forests of Syltharin 1-2",
                "A beautiful forest city created by the Thylvari",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-2, -2, "Forests of Syltharin 2-2",
                "A beautiful forest city created by the Thylvari",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-3, -2, "Forests of Syltharin 3-2",
                "A beautiful forest city created by the Thylvari",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(-4, -2, "Lisryggad",
                "A beautiful forest city created by the Thylvari",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(0, 0, "Fields of Tholstrid",
                "Vast fields with farmers",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(0, 1, "Fields of Tholstrid",
                "Vast fields with farmers",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(0, 2, "Gates of Tholstrid",
                "Grand gates for a grand city",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(0, 3, "Tholstrid",
                "Grand City",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(1, -1, "Marshes of the Enarrh-Khirss 1-1",
                "The marshes",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(2, -1, "Marshes of the Enarrh-Khirss 2-1",
                "The marshes",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(3, -1, "Marshes of the Enarrh-Khirss 3-1",
                "The marshes",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(4, -1, "Marshes of the Enarrh-Khirss 4-1",
                "The marshes",
                "/Engine;component/Images/Locations/125x125.png");

            newWorld.AddLocation(5, -1, "Hlomark",
                "The forests are dense with trees",
                "/Engine;component/Images/Locations/125x125.png");

            return newWorld;
        }
    }
}
