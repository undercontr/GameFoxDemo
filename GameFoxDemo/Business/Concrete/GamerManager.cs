using System;
using GameFoxDemo.Business.Abstract;
using GameFoxDemo.Campaigns;
using TcKimlikValidation;

namespace GameFoxDemo
{
    class GamerManager : IGamerManager
    {
        private readonly IGamerValidation _gamerValidation;

        public GamerManager(IGamerValidation gamerValidation)
        {
            _gamerValidation = gamerValidation;
        }

        public void RegisterAccount(IGamer gamer)
        {
            if (_gamerValidation.Validate(gamer))
            {
                Console.WriteLine($@"{gamer.FirstName} {gamer.LastName} is registered. Welcome Dovahkiin!");
            }
            else
            {
                Console.WriteLine($@"Dear {gamer.FirstName}, we are sorry to tell you that you are a big fat liar. YOUR INFORMATION ARE INCORRECT!");
            }
        }

        public void UpdateGamerInfo(IGamer gamer)
        {
            
            // Update simulation
            // let say gamer.Address is updated

            Console.WriteLine($@"Dear {gamer.FirstName}, your profile is updated!");
        }

        public void RemoveAccount(IGamer gamer)
        {
            Console.WriteLine($@"Dear {gamer.FirstName}, we are sorry you are leaving us.");

            //set account as archived NOT DELETE THE ACCOUNT
        }

        public void AccountInfo(IGamer gamer)
        {
            Console.WriteLine($@"Your account info: Id: {gamer.Id} | First Name: {gamer.FirstName} | Last Name: {gamer.LastName} | Tc No: {gamer.TcNo}| Birthday: {gamer.DateOfBirth} | Address: {gamer.Address}");
            Console.WriteLine("The games you purchased:");
            foreach (var game in gamer.GamesPuchased)
            {
                Console.WriteLine(game.ProductName);
            }
        }

        public void PurchaseGame(IGames game, IGamer giftGamer = null, params ICampaign[] campaigns)
        {
            Console.WriteLine($@"{game.ProductName} is purchased!");

            if (giftGamer != null)
            {
                Console.Write($@"And it is gifted to {giftGamer.FirstName}");
            }

            if (campaigns.Length != 0)
            {
                Console.WriteLine("Added campaings are below:");
                foreach (ICampaign campaign in campaigns)
                {
                    Console.WriteLine($@"{campaign.CampaignName}");
                }
            }
        }

    }
}
