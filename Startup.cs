using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaMattersCCV2.Models;
using MediaMattersCCV2.Models.album;
using MediaMattersCCV2.Models.book;
using MediaMattersCCV2.Models.game;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MediaMattersCCV2
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<IAlbum, AlbumRepo>();
            services.AddScoped<IBook, BookRepo>();
            services.AddScoped<IGame, GameRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
