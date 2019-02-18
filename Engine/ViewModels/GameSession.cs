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
        public Player currentPlayer { get; set; }

        public GameSession()
        {
            currentPlayer = new Player();
            currentPlayer.Name = "Gord";
            currentPlayer.CharacterClass = "Barbarian";
            currentPlayer.HitPoints = 10;
            currentPlayer.Gold = 25;
            currentPlayer.ExperiencePoints = 0;
            currentPlayer.Level = 1;
        }
    }
}
