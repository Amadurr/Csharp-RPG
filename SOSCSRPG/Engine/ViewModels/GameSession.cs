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
            currentPlayer.name = "Gord";
            currentPlayer.characterClass = "Barbarian";
            currentPlayer.hitPoints = 10;
            currentPlayer.gold = 1000000;
            currentPlayer.experiencePoints = 0;
            currentPlayer.level = 1;
        }
    }
}
