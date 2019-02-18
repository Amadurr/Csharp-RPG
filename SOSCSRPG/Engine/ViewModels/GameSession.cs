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
            currentPlayer.gold = 100;
        }
    }
}
