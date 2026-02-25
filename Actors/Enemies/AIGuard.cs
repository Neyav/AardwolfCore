using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AardwolfCore.Actors;
using AardwolfCore.Animation;
using AardwolfCore;

namespace AardwolfCore.Actors.Enemies
{
    public class AIGuard : AnimatedActor
    {
        public AIGuard(float widthPosition, float heightPosition, int angle)
        {
            Health = 25;
            MaxHealth = 25;
            Angle = angle;
            WidthPosition = widthPosition + 0.5f;
            HeightPosition = heightPosition + 0.5f;

            int grdSprStart = 50; // Default sprite start for guards

            if (_gameDataType == gameDataType.SpearOfDestiny)
            {
                grdSprStart = 54;
            }

            // Set default sprite frames for the guard
            _spriteAnimation.addSequenceFrame("s_grdstand", grdSprStart, 0, "s_grdstand");

            // Walking animation frames.
            _spriteAnimation.addSequenceFrame("s_grdpath1", grdSprStart + 8, 20, "s_grdpath1s");
            _spriteAnimation.addSequenceFrame("s_grdpath1s", grdSprStart + 8, 5, "s_grdpath2");
            _spriteAnimation.addSequenceFrame("s_grdpath2", grdSprStart + 16, 15, "s_grdpath3");
            _spriteAnimation.addSequenceFrame("s_grdpath3", grdSprStart + 24, 20, "s_grdpath3s");
            _spriteAnimation.addSequenceFrame("s_grdpath3s", grdSprStart + 24, 5, "s_grdpath4");
            _spriteAnimation.addSequenceFrame("s_grdpath4", grdSprStart + 32, 15, "s_grdpath1");

            // Pain frames.
            _spriteAnimation.addFrame("s_grdpain1", grdSprStart + 40, 10, "s_grdchase1");
            _spriteAnimation.addFrame("s_grdpain2", grdSprStart + 44, 10, "s_grdchase1");

            // Shooting frames.
            _spriteAnimation.addFrame("s_grdshoot1", grdSprStart + 46, 20, "s_grdshoot2");
            _spriteAnimation.addFrame("s_grdshoot2", grdSprStart + 47, 20, "s_grdshoot3");
            _spriteAnimation.addFrame("s_grdshoot3", grdSprStart + 48, 20, "s_grdchase1");

            // Chase frames.
            _spriteAnimation.addSequenceFrame("s_grdchase1", grdSprStart + 8, 10, "s_grdchase1s");
            _spriteAnimation.addSequenceFrame("s_grdchase1s", grdSprStart + 8, 3, "s_grdchase2");
            _spriteAnimation.addSequenceFrame("s_grdchase2", grdSprStart + 16, 8, "s_grdchase3");
            _spriteAnimation.addSequenceFrame("s_grdchase3", grdSprStart + 24, 10, "s_grdchase3s");
            _spriteAnimation.addSequenceFrame("s_grdchase3s", grdSprStart + 24, 3, "s_grdchase4");
            _spriteAnimation.addSequenceFrame("s_grdchase4", grdSprStart + 32, 8, "s_grdchase1");

            // Death Frames.
            _spriteAnimation.addFrame("s_grddie1", grdSprStart + 41, 10, "s_grddie2");
            _spriteAnimation.addFrame("s_grddie2", grdSprStart + 42, 10, "s_grddie3");
            _spriteAnimation.addFrame("s_grddie3", grdSprStart + 43, 10, "s_grddie4");
            _spriteAnimation.addFrame("s_grddie4", grdSprStart + 45, 0, "s_grddie4");

            _spriteAnimation.setCurrentFrame("s_grdstand");
        }
    }
}
