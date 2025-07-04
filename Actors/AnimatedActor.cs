using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AardwolfCore.Actors;
using AardwolfCore.Animation;   

namespace AardwolfCore.Actors
{
    public class AnimatedActor : Actor
    {
        public SpriteAnimation _spriteAnimation { get; set; }

        public int getAnimationFrame(float Yaw, double timeDelta)
        {
            // Get the current frame from the sprite animation
            return _spriteAnimation.getFrame(Yaw, Angle, timeDelta);
        }

        public void forceAnimationFrame(string frameName)
        {
            // Set the current frame to a specific frame
            _spriteAnimation.setCurrentFrame(frameName);
        }

        public AnimatedActor()
        {
            _spriteAnimation = new SpriteAnimation();
        }
    }
}
