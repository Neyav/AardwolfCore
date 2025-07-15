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
            WidthPosition = widthPosition;
            HeightPosition = heightPosition;

            int grdSprStart = 50; // Default sprite start for guards

            if (_isSoD)
            {
                grdSprStart = 54;
            }

            // Set default sprite frames for the guard
            _spriteAnimation.addFrame("s_grdstand", grdSprStart, grdSprStart + 1, grdSprStart + 2, grdSprStart + 3,
                            grdSprStart + 4, grdSprStart + 5, grdSprStart + 6, grdSprStart + 7, 0, "s_grdstand");

            // Walking animation frames.
            _spriteAnimation.addFrame("s_grdpath1", grdSprStart + 8, grdSprStart + 9, grdSprStart + 10, grdSprStart + 11,
                            grdSprStart + 12, grdSprStart + 13, grdSprStart + 14, grdSprStart + 15, 20, "s_grdpath1s");
            _spriteAnimation.addFrame("s_grdpath1s", grdSprStart + 8, grdSprStart + 9, grdSprStart + 10, grdSprStart + 11,
                            grdSprStart + 12, grdSprStart + 13, grdSprStart + 14, grdSprStart + 15, 5, "s_grdpath2");
            _spriteAnimation.addFrame("s_grdpath2", grdSprStart + 16, grdSprStart + 17, grdSprStart + 18, grdSprStart + 19,
                            grdSprStart + 20, grdSprStart + 21, grdSprStart + 22, grdSprStart + 23, 15, "s_grdpath3");
            _spriteAnimation.addFrame("s_grdpath3", grdSprStart + 24, grdSprStart + 25, grdSprStart + 26, grdSprStart + 27,
                            grdSprStart + 28, grdSprStart + 29, grdSprStart + 30, grdSprStart + 31, 20, "s_grdpath3s");
            _spriteAnimation.addFrame("s_grdpath3s", grdSprStart + 24, grdSprStart + 25, grdSprStart + 26, grdSprStart + 27,
                            grdSprStart + 28, grdSprStart + 29, grdSprStart + 30, grdSprStart + 31, 5, "s_grdpath4");
            _spriteAnimation.addFrame("s_grdpath4", grdSprStart + 32, grdSprStart + 33, grdSprStart + 34, grdSprStart + 35,
                            grdSprStart + 36, grdSprStart + 37, grdSprStart + 38, grdSprStart + 39, 15, "s_grdpath1");

            // Pain frames.
            _spriteAnimation.addFrame("s_grdpain1", grdSprStart + 40, 10, "s_grdchase1");
            _spriteAnimation.addFrame("s_grdpain2", grdSprStart + 44, 10, "s_grdchase1");

            // Shooting frames.
            _spriteAnimation.addFrame("s_grdshoot1", grdSprStart + 46, 20, "s_grdshoot2");
            _spriteAnimation.addFrame("s_grdshoot2", grdSprStart + 47, 20, "s_grdshoot3");
            _spriteAnimation.addFrame("s_grdshoot3", grdSprStart + 48, 20, "s_grdchase1");

            // Chase frames.
            _spriteAnimation.addFrame("s_grdchase1", grdSprStart + 8, grdSprStart + 9, grdSprStart + 10, grdSprStart + 11,
                            grdSprStart + 12, grdSprStart + 13, grdSprStart + 14, grdSprStart + 15, 10, "s_grdchase1s");
            _spriteAnimation.addFrame("s_grdchase1s", grdSprStart + 8, grdSprStart + 9, grdSprStart + 10, grdSprStart + 11,
                            grdSprStart + 12, grdSprStart + 13, grdSprStart + 14, grdSprStart + 15, 3, "s_grdchase2");
            _spriteAnimation.addFrame("s_grdchase2", grdSprStart + 16, grdSprStart + 17, grdSprStart + 18, grdSprStart + 19,
                            grdSprStart + 20, grdSprStart + 21, grdSprStart + 22, grdSprStart + 23, 8, "s_grdchase3");
            _spriteAnimation.addFrame("s_grdchase3", grdSprStart + 24, grdSprStart + 25, grdSprStart + 26, grdSprStart + 27,
                            grdSprStart + 28, grdSprStart + 29, grdSprStart + 30, grdSprStart + 31, 10, "s_grdchase3s");
            _spriteAnimation.addFrame("s_grdchase3s", grdSprStart + 24, grdSprStart + 25, grdSprStart + 26, grdSprStart + 27,
                            grdSprStart + 28, grdSprStart + 29, grdSprStart + 30, grdSprStart + 31, 3, "s_grdchase4");
            _spriteAnimation.addFrame("s_grdchase4", grdSprStart + 32, grdSprStart + 33, grdSprStart + 34, grdSprStart + 35,
                            grdSprStart + 36, grdSprStart + 37, grdSprStart + 38, grdSprStart + 39, 8, "s_grdchase1");

            // Death Frames.
            _spriteAnimation.addFrame("s_grddie1", grdSprStart + 41, 10, "s_grddie2");
            _spriteAnimation.addFrame("s_grddie2", grdSprStart + 42, 10, "s_grddie3");
            _spriteAnimation.addFrame("s_grddie3", grdSprStart + 43, 10, "s_grddie4");
            _spriteAnimation.addFrame("s_grddie4", grdSprStart + 45, 0, "s_grddie4");

            _spriteAnimation.setCurrentFrame("s_grdstand");
        }
    }
}
