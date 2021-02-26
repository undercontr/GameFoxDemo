using System;
using System.Collections.Generic;
using System.Text;

namespace GameFoxDemo
{
    public interface IGamesManager
    {
        public void AddGame(IGames game);
        public void UpdateGame(IGames game);
        public void DeleteGame(IGames game);
        public void BringGameInfo(IGames game);
    }
}
