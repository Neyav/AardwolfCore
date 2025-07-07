using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AardwolfCore.Animation
{
    internal class SpriteFrame
    {
        // Sprite Frames will be Front, FrontLeft, Left, BackLeft, Back, BackRight, Right, FrontRight
        private int[] _SpriteTexture;
        private bool _SpriteRotates;
        private int _SpriteTime;
        private int _TimeElapsed;
        public string _nextSprite;

        public void setFrames(int Front, int FrontLeft, int Left, int BackLeft, int Back, int BackRight, int Right, int FrontRight, int SpriteTime, string nextSprite)
        {
            _SpriteTexture[0] = Front;
            _SpriteTexture[1] = FrontLeft;
            _SpriteTexture[2] = Left;
            _SpriteTexture[3] = BackLeft;
            _SpriteTexture[4] = Back;
            _SpriteTexture[5] = BackRight;
            _SpriteTexture[6] = Right;
            _SpriteTexture[7] = FrontRight;

            _SpriteRotates = true;
            _SpriteTime = SpriteTime;
            _nextSprite = nextSprite;

            _TimeElapsed = 0;
        }

        public void setFrames(int Front, int SpriteTime, string nextSprite)
        {

            _SpriteTexture[0] = Front;
            _SpriteRotates = false;

            _SpriteTime = SpriteTime;
            _nextSprite = nextSprite;

            _TimeElapsed = 0;
        }

        public int getFrame(float spriteAngle, float viewerAngle)
        {
            if (!_SpriteRotates)
                return _SpriteTexture[0];

            const int frameCount = 8;
            const float sliceSize = 360f / frameCount;  // 45°
            const float halfSlice = sliceSize / 2f;  // 22.5°

            // Compute relative angle so it grows counter-clockwise:
            float rel = (spriteAngle - viewerAngle + 360f) % 360f;

            // Round to nearest slice:
            rel = (rel + halfSlice) % 360f;

            // Map into 0…7
            int idx = (int)(rel / sliceSize);

            // Safety clamp
            if (idx < 0) idx = 0;
            else if (idx >= frameCount) idx = frameCount - 1;

            return _SpriteTexture[idx];
        }

        public bool calculateNextFrame(int timeDelta)
        {
            if (_SpriteTime == 0)
                return false; // No time set for sprite switching

            _TimeElapsed += timeDelta;
            if (_TimeElapsed >= _SpriteTime)
            {
                timeDelta -= (_TimeElapsed - _SpriteTime);
                _TimeElapsed = 0;
                return true; // Time to switch frames
            }

            return false; // We don't need to switch frames.
        }

        public SpriteFrame()
        {
            _SpriteTexture = new int[8];
        }
    }
}
