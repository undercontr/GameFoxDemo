using System;
using System.Collections.Generic;
using System.Text;
using GameFoxDemo.Campaigns;
using GameFoxDemo.Interfaces;

namespace GameFoxDemo
{
    class GamerManager : IGamerManager
    {


        public void RegisterAccount(IGamer gamer)
        {
            Console.WriteLine($@"{gamer.FirstName} {gamer.LastName} is registered. Welcome Dovahkiin!");
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
            Console.WriteLine($@"Your account info: Id: {gamer.Id} | First Name: {gamer.FirstName} | Last Name: {gamer.LastName} | Tc No: {gamer.TCNo}| Birthday: {gamer.DateOfBirth} | Address: {gamer.Address}");
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
                Console.WriteLine($@"And it is gifted to {giftGamer.FirstName}");
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

        public void TCKimlikValidation(IGamer gamer)
        {
            ITcKimlik tcValidation = new TcKimlikValidationLib();

            tcValidation.FirstName = gamer.FirstName;
            tcValidation.LastName = gamer.LastName;
            tcValidation.YearOfBirth = gamer.DateOfBirth.Year.ToString();
            tcValidation.TcNo = gamer.TCNo;

            tcValidation.Validate();
        }
    }
}
