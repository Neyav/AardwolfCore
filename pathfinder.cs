using System.Diagnostics;
using System.Numerics;

namespace AardwolfCore
{
    public class pathfinderNode
    {
        public int WidthPosition;
        public int HeightPosition;

        public int CostFromStart;

        public List<pathfinderNode> nodeConnections = new List<pathfinderNode>();
    }
    public class pathfinder
    {
        private maphandler _mapdata;
        private List<pathfinderNode> _pathNodes;

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
            _pathNodes = new List<pathfinderNode>();
        }
    }   

}
