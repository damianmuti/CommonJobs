﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client;

namespace CommonJobs.Raven.Migrations
{
    public enum MigrationStatus
    {
        NotInstalled,
        Installing,
        Installed,
        InstalledObsolete,
        Uninstalling
    }
}
