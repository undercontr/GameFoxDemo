using System;
using System.Collections.Generic;
using System.Text;

namespace GameFoxDemo.Campaigns
{
    public interface ICampaignManager
    {
        public void AddCampaign(ICampaign camp);
        public void UpdateCampaign(ICampaign camp);
        public void DeleteCampaign(ICampaign camp);
    }
}
