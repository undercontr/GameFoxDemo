using System;
using System.Collections.Generic;
using System.Text;
using GameFoxDemo.Campaigns;

namespace GameFoxDemo
{
    public interface IGamerManager
    {
        public void RegisterAccount(IGamer gamer);
        public void UpdateGamerInfo(IGamer gamer);
        public void RemoveAccount(IGamer gamer);
        public void AccountInfo(IGamer gamer);
        public void PurchaseGame(IGames game, IGamer giftGamer, params ICampaign[] campaigns);
        public void TcKimlikValidation(IGamer gamer);
    }
}
