using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AardwolfCore
{
    public class gamesession
    {
        private int _mapnumber;
        private int _difficulty;
        private gameDataType _gameDataType;
        private dataHandler _dataHandler;
        maphandler _mapData;

        public int getLevels()
        {
            return _dataHandler.getLevels();
        }
        public string getLevelName(int level)
        {
            return _dataHandler.getLevelName(level);
        }

        public void loadLevel(int level, int difficulty)
        {
            if (level > _dataHandler.getLevels())
            {
                return;
            }

            _mapnumber = level;
            _difficulty = difficulty;

            _mapData = new maphandler(_gameDataType);
            _mapData.importMapData(_dataHandler.getLevelData(level), _dataHandler.levelHeight(level), _dataHandler.levelWidth(level));

            _mapnumber = level;
            _difficulty = difficulty;
        }

        // Not necessary for a game, just for testing
        public VSWAPHeader TEST_getVSWAPHeader()
        {
            return _dataHandler.getVSWAPHeader;
        }
        public dataHandler TEST_getDataHandler()
        {
            return _dataHandler;
        }
        public gamesession(gameDataType gameDataType)
        {
            this._mapnumber = 0;
            this._difficulty = 0;
            this._gameDataType = gameDataType;

            this._dataHandler = new dataHandler();
            _dataHandler.loadAllData(_gameDataType);

            _dataHandler.parseLevelData();

            _mapData = null;
        }
    }
}
