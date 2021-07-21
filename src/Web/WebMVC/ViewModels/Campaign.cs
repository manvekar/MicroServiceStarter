﻿using System.Collections.Generic;

namespace microServiceStarter.Web.WebMVC.ViewModels
{
    public record Campaign
    {
        public int PageIndex { get; init; }
        public int PageSize { get; init; }
        public int Count { get; init; }
        public List<CampaignItem> Data { get; init; }
    }
}