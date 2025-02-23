using AutoMapper;
using FinanceManager.Domain.Entities;
using FinanceManager.App.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinanceManager.App.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryModel>().ReverseMap();
        }
    }
}
