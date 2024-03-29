﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Troydon_Resume_Online_NET_Core_.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Troydon_Resume_Online_NET_Core_.Models.Account;
using Troydon_Resume_Online_NET_Core_.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Troydon_Resume_Online_NET_Core_
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<FeedbackDataContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("FeedbackDataContext");
                options.UseSqlServer(connectionString);
            });

            // Add Identity Services
            services.AddDbContext<IdentityDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString
                    ("IdentityDataContext"),
                optionsBuilders =>
                optionsBuilders.MigrationsAssembly("Troydon-Resume-Online(NET Core)")));

            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<IdentityDbContext>()
            // Tokens for generating pass a two-factor auth
            .AddDefaultTokenProviders();

            services.AddScoped<IUserClaimsPrincipalFactory<User>, MyUserClaimsPrincipalFactory>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly",
                    policy =>
                    policy.RequireClaim("AdminNumber")) ;
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AtLeast21", policy =>
                    policy.Requirements.Add(new AdminNumberRequirement(964212, 18)));
            });

            // Add all of your handlers to DI.
            services.AddSingleton<IAuthorizationHandler, AdminNumberHandler>();
            // MyHandler2, ...


            // Configure your policies
            services.AddAuthorization(options =>
                  options.AddPolicy("Something",
                  policy => policy.RequireClaim("Permission", "CanViewPage", "CanViewAnything")));

            // TO DO: Add sign up with LinkedIn/Facebook

            services.AddTransient<FormattingService>();

            services.AddDataProtection()
                    .DisableAutomaticKeyGeneration()
                    .SetDefaultKeyLifetime(new TimeSpan(14, 0, 0, 0));

            var secret = Configuration["PaymentPass"];

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            var cookiePolicyOptions = new CookiePolicyOptions
            {
                MinimumSameSitePolicy = SameSiteMode.Strict,
            };

            app.UseCookiePolicy(cookiePolicyOptions);

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
