using AutoMapper;
using FinanceManager.App.Cadastros;
using FinanceManager.App.Models;
using FinanceManager.App.Base;
using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Context;
using FinanceManager.Repository.Repository;
using FinanceManager.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FinanceManager.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("Config/DatabaseSettings.txt");

            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                    .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            Services.AddScoped<IBaseRepository<PaymentMethod>, BaseRepository<PaymentMethod>>();
            Services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            Services.AddScoped<IBaseRepository<Transaction>, BaseRepository<Transaction>>();

            // Services
            Services.AddScoped<IBaseService<User>, BaseService<User>>();
            Services.AddScoped<IBaseService<PaymentMethod>, BaseService<PaymentMethod>>();
            Services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            Services.AddScoped<IBaseService<Transaction>, BaseService<Transaction>>();

            // Formulários
            //Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<RegisterPaymentMethod, RegisterPaymentMethod>();
            Services.AddTransient<RegisterCategory, RegisterCategory>();
            Services.AddTransient<RegisterTransaction, RegisterTransaction>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<User, UserModel>();
                config.CreateMap<PaymentMethod, PaymentMethodModel>();
                config.CreateMap<Category, CategoryModel>();
                config.CreateMap<Transaction, TransactionModel>()
                    .ForMember(d => d.Category, d => d.MapFrom(x => x.Category!.Name))
                    .ForMember(d => d.CategoryId, d => d.MapFrom(x => x.Category!.Id));
            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
