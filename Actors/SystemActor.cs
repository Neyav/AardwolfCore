using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AardwolfCore.Actors
{
    // SystemActor is the phantom actor that will be used to access the event system.
    // It will be responsibile for initalizing the event system and handling events.
    public class SystemActor : Actor
    {
        public SystemActor(gameDataType gameDataType)
        {
            // These statics being set here MEANS a systemActor must be created before any other actors are created.

            _gameDataType = gameDataType;
            SkillSetting = 0; // Default skill setting, can be changed later
        }
    }
}
