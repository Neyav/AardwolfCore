using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AardwolfCore
{
    class gamesession
    {
        private int _mapnumber;
        private int _difficulty;
        private bool _isSOD;
        private dataHandler _dataHandler;

        public gamesession(bool isSOD, int mapnumber, int difficulty)
        {
            this._mapnumber = mapnumber;
            this._difficulty = difficulty;
            this._isSOD = isSOD;

            this._dataHandler = new dataHandler();
            _dataHandler.loadAllData(_isSOD);
        }
    }
}
