using System;
using System.Collections.Generic;
using System.Text;

namespace GameFoxDemo.Campaigns
{
    class NewYearCampaign : ICampaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDesc { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
