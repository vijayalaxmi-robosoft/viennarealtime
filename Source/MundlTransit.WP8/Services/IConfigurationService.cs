﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundlTransit.WP8.Services
{
    public interface IConfigurationService
    {
        string WienerLinienApiKey { get; }

        string GitHubUrl { get; }
        string PrivacyPolicyUrl { get; }

        string MapApplicationId { get; }
        string MapAuthenticationToken { get; }

        bool UsingDefaultReferenceDatabase { get; set; }
        string CustomReferenceDatabaseName { get; set; }
        DateTime ReferenceDatabaseBuildDate { get; set; }
    }
}
