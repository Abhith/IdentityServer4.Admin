﻿using Microsoft.Extensions.Options;
using SkorubaIdentityServer4Admin.Admin.Configuration.Interfaces;

namespace SkorubaIdentityServer4Admin.Admin.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {
        public IAdminConfiguration AdminConfiguration { get; set; }

        public RootConfiguration(IOptions<AdminConfiguration> adminConfiguration)
        {
            AdminConfiguration = adminConfiguration.Value;
        }
    }
}
