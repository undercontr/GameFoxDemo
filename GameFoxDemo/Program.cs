using System;
using System.Collections.Generic;
using GameFoxDemo.Campaigns;

namespace GameFoxDemo
{
    class Program
    {
        static void Main(string[] args) //PRESENTATION LAYER
        {

            Games gameOne = new Games()
            {
                Id = 1,
                ProductName = "The Elder Scrolls V Skyrim",
                Description = "One of the best games released in this century (yet)",
                DateOfRelease = new DateTime(2011, 11, 11)
            };

            Games gameTwo = new Games()
            {
                Id = 2,
                ProductName = "Cyberpunk 2077",
                Description = "Night City is not the future. IT'S A WARNING!",
                DateOfRelease = new DateTime(2020, 12, 10)
            };

            Gamer gamer = new Gamer()
            {
                Id = 1,
                Username = "undercontr",
                FirstName = "Önder",
                LastName = "Alkan",
                TCNo = "12345678900",
                DateOfBirth = new DateTime(1991, 09, 07),
                Address = "Şu sokak",
                GamesPuchased = new List<IGames>() { gameOne }

            };


            CampaignManager campaignManager = new CampaignManager();
            NewYearCampaign newYearCampaign = new NewYearCampaign()
            {
                Id = 1,
                CampaignName = "New Year Campaign",
                CampaignDesc = "10% Off!",
                DateAdded = DateTime.Now
            };
            HalloweenDiscountCampaign halloweenDiscountCampaign = new HalloweenDiscountCampaign()
            {
                Id = 2,
                CampaignName = "Halloween Discount Campaign",
                CampaignDesc = "25% Off!",
                DateAdded = DateTime.Now
            };

            GamerManager gamerManager = new GamerManager();

            gamerManager.RegisterAccount(gamer);
            gamerManager.TCKimlikValidation(gamer);
            gamerManager.AccountInfo(gamer);

            gamerManager.PurchaseGame(gameTwo, null, newYearCampaign, halloweenDiscountCampaign);
            gamerManager.PurchaseGame(gameOne);

            GamesManager gamesManager = new GamesManager();

            gamesManager.AddGame(gameOne);
            gamesManager.DeleteGame(gameTwo);
            gamesManager.UpdateGame(gameOne);
            gamesManager.BringGameInfo(gameOne);

            

        }
    }
}
