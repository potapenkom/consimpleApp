﻿using System;
using Microsoft.Extensions.DependencyInjection;





namespace consimpleApp.Services
{
    public static class Bootstrapper
    {
        public static void UseServices(this IServiceCollection services)
        {
            services.AddHttpClient<IRootobjectService, RootobjectService>();
        }
    }
}
