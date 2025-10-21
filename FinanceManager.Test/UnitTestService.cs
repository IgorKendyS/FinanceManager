using AutoMapper;
using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Context;
using FinanceManager.Repository.Repository;
using FinanceManager.Service.Services;
using FinanceManager.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace FinanceManager.Test
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "financas";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};" +
                            $"Uid={username};Pwd={password}";
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<User, User>();
            }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestInsertUser()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<User>>();
            var usuario = new User
            {
                Name = "Igor Kendy Sakaguchi",
                Email = "igkendy.s@gmail.com",
                Phone = "+5518997907790",
                PasswordHash = "Senha@Forte123",
                LastLogin = DateTime.UtcNow,
                Created = DateTime.UtcNow
            };

            var result = usuarioService.Add<User, User, UserValidator>(usuario);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectUser()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<User>>();

            var result = usuarioService.Get<User>();
            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}
