using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace GameFoxDemo.Campaigns
{
    class CampaignManager : ICampaignManager
    {
        public void AddCampaign(ICampaign camp)
        {
            Console.WriteLine($@"{camp.CampaignName} is added to the campaign repository. Date Added: {camp.DateAdded}");
        }

        public void UpdateCampaign(ICampaign camp)
        {
            Console.WriteLine($@"{camp.CampaignName} is updated!");
        }
        public void DeleteCampaign(ICampaign camp)
        {
            Console.WriteLine($@"{camp.CampaignName} is removed from the campaign repository");
        }
    }
}
