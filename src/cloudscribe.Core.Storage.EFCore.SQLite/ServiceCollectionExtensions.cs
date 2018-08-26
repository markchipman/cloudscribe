﻿using cloudscribe.Core.Models;
using cloudscribe.Core.Storage.EFCore.Common;
using cloudscribe.Core.Storage.EFCore.SQLite;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCloudscribeCoreEFStorageSQLite(
            this IServiceCollection services,
            string connectionString
            )
        {
            services.AddCloudscribeCoreEFCommon();

            services.AddDbContext<CoreDbContext>(options =>
                    options.UseSqlite(connectionString));

            services.AddScoped<ICoreDbContext, CoreDbContext>();
            services.AddScoped<IDataPlatformInfo, DataPlatformInfo>();

            return services;
        }

    }
}
