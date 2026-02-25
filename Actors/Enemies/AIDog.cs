using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AardwolfCore.Actors.Enemies
{
    public class AIDog : AnimatedActor
    {
        public AIDog(float widthPosition, float heightPosition, int angle)
        {
            Health = 25;
            MaxHealth = 25;
            Angle = angle;
            WidthPosition = widthPosition + 0.5f;
            HeightPosition = heightPosition + 0.5f;

            int dogSprStart = 99; // Default sprite start for guards

            if (_gameDataType == gameDataType.SpearOfDestiny)
            {
                dogSprStart = 103;
            }

            // Dog patrol animation.
            _spriteAnimation.addSequenceFrame("s_dogpath1", dogSprStart, 20, "s_dogpath1s");
            _spriteAnimation.addSequenceFrame("s_dogpath1s", dogSprStart, 5, "s_dogpath2");
            _spriteAnimation.addSequenceFrame("s_dogpath2", dogSprStart + 8, 15, "s_dogpath3");
            _spriteAnimation.addSequenceFrame("s_dogpath3", dogSprStart + 16, 20, "s_dogpath3s");
            _spriteAnimation.addSequenceFrame("s_dogpath3s", dogSprStart + 16, 5, "s_dogpath4");
            _spriteAnimation.addSequenceFrame("s_dogpath4", dogSprStart + 24, 15, "s_dogpath1");

            // Dog Jump attack.
            _spriteAnimation.addFrame("s_dogjump1", dogSprStart + 36, 10, "s_dogjump2");
            _spriteAnimation.addFrame("s_dogjump2", dogSprStart + 37, 10, "s_dogjump3");
            _spriteAnimation.addFrame("s_dogjump3", dogSprStart + 38, 10, "s_dogjump4");
            _spriteAnimation.addFrame("s_dogjump4", dogSprStart + 39, 10, "s_dogjump5");
            _spriteAnimation.addFrame("s_dogjump5", dogSprStart + 40, 10, "s_dogchase1");

            // Chase frames.
            _spriteAnimation.addSequenceFrame("s_dogchase1", dogSprStart, 10, "s_dogchase1s");
            _spriteAnimation.addSequenceFrame("s_dogchase1s", dogSprStart, 3, "s_dogchase2");
            _spriteAnimation.addSequenceFrame("s_dogchase2", dogSprStart + 8, 8, "s_dogchase3");
            _spriteAnimation.addSequenceFrame("s_dogchase3", dogSprStart + 16, 10, "s_dogchase3s");
            _spriteAnimation.addSequenceFrame("s_dogchase3s", dogSprStart + 16, 3, "s_dogchase4");
            _spriteAnimation.addSequenceFrame("s_dogchase4", dogSprStart + 24, 8, "s_dogchase1");

            // Death Frames.
            _spriteAnimation.addFrame("s_dogdie1", dogSprStart + 32, 15, "s_dogdie2");
            _spriteAnimation.addFrame("s_dogdie2", dogSprStart + 33, 15, "s_dogdie3");
            _spriteAnimation.addFrame("s_dogdie3", dogSprStart + 34, 15, "s_dogdead");
            _spriteAnimation.addFrame("s_dogdead", dogSprStart + 35, 15, "s_dogdead");

            _spriteAnimation.setCurrentFrame("s_dogpath1");
        }
    }
}
