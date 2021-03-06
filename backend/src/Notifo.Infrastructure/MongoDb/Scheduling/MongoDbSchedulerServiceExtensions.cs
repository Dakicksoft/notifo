﻿// ==========================================================================
//  Notifo.io
// ==========================================================================
//  Copyright (c) Sebastian Stehle
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Notifo.Infrastructure.MongoDb.Scheduling;
using Notifo.Infrastructure.Scheduling;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MongoDbSchedulerServiceExtensions
    {
        public static void AddMongoScheduler(this IServiceCollection services)
        {
            services.AddSingletonAs<MongoDbSchedulerProvider>()
                .As<ISchedulerProvider>();
        }
    }
}
