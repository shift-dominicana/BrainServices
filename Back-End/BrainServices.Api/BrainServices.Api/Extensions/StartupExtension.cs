﻿using AutoMapper;
using BussinesLayer.Interfaces.Authors;
using BussinesLayer.Interfaces.Books;
using BussinesLayer.Interfaces.Genres;
using DataLayer.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;
using BussinesLayer.Services.Authors;
using BussinesLayer.Services.Books;
using BussinesLayer.Services.Genres;
using BussinesLayer.Interfaces.Users;
using BussinesLayer.Services.Users;

namespace WebApi.Extensions
{
    public static class StartupExtension
    {

        public static void ConfigureDbContext(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<MainDbContext>(opt =>
                opt.UseNpgsql(configuration.GetConnectionString("MainDb")));

            //services.AddDbContext<MainDbContext>(opt =>
            //  opt.UseSqlServer(configuration.GetConnectionString("MainDb")));
        }

        public static void ServicesImplementations(this IServiceCollection services)
        {
            //services.AddTransient<IAuthorService, AuthorService>();
            //services.AddTransient<IBooksService, BooksService>();
            //services.AddTransient<IGenresService, GenresService>();
            services.AddTransient<IUsersService, UsersService>();
        }

        public static void ConfigureAutomapper(this IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(Startup));
            var config = new MapperConfiguration(cfg =>
            {
                var mainAssembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(c => c.GetName().Name == "DataLayer");
                cfg.AddMaps(mainAssembly);
                cfg.AllowNullCollections = true;
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo() {Title = "Books Api", Version = "v1"});
            });
        }


        public static void ConfigureSwaggerMiddleWare(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Books Api");
                opt.RoutePrefix = "swagger";
            });
        }
    }
}
