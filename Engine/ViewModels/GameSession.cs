using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Gord";
            CurrentPlayer.CharacterClass = "Barbarian";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 25;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location
            {
                LocationName = "Home",
                XCoordinate = 0,
                YCoordinate = -1,
                LocationDescription = "This is your house",
                ImageName = "/Engine;component/Images/Locations/125x125.png"
            };
        }
    }
}
