using System.Diagnostics;
using System.Numerics;

namespace AardwolfCore
{

    public class pathfinder
    {
        private maphandler _mapdata;

        public bool ignorePushWalls;

        public bool solveMaze()
        {
            return true;
        }
        public void preparePathFinder()
        {
        }
        public pathfinder(ref maphandler mapdata)
        {
            _mapdata = mapdata;
        }
    }   

}
