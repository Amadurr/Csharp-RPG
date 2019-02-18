using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Player
    {
        string name { get; set; }
        string characterClass { get; set; }
        int hitPoints { get; set; }
        int experiencePoints { get; set; }
        int level { get; set; }
        int gold { get; set; }
    }
}
