// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Framework.Logging;

namespace Microsoft.Data.Entity.SqlServer
{
    public class SqlServerDatabase : MigrationsEnabledDatabase
    {
        public SqlServerDatabase(
            [NotNull] DbContextConfiguration configuration,
            [NotNull] ILoggerFactory loggerFactory)
            : base(configuration, loggerFactory)
        {
        }
    }
}
