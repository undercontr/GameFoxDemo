using System;
using System.Collections.Generic;
using System.Text;

namespace GameFoxDemo
{
    interface IGamerManager
    {
        public void RegisterAccount(IGamer gamer);
        public void UpdateGamerInfo(IGamer gamer);
        public void RemoveAccount(IGamer gamer);
        public void AccountInfo(IGamer gamer);
        public void TCKimlikValidation(IGamer gamer);
    }
}
