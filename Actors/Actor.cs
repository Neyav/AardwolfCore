using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AardwolfCore.Actors
{
    public class Actor
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Angle { get; set; }
        public float WidthPosition { get; set; }
        public float HeightPosition { get; set; }
        // SkillSetting is used to determine the difficulty or skill level of the actor
        // This is static so it can be set globally for all actors.
        protected static int SkillSetting { get; set; }

        protected static gameDataType _gameDataType; // Static variable to determine if the game is SOD (Spear of Destiny)
    }
}
