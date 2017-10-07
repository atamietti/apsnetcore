﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Data;
using StoreOfBuild.Domain;


namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {

                services.AddDbContext<ApplicationDbContext>(options=>
                     options.UseSqlServer(connectionString));

                services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}