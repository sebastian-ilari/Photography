using AutoMapper;
using Photography.Converters;
using Photography.Models;

namespace Photography.App_Start
{
    public class AutomapperConfiguration
    {
        /*
         * DEFAULT SYNTAX
         * 
         * Mapper.CreateMap<Category, CategoryViewModel>();
         * 
         * EXPLICIT PROPERTU MAPPING
         * 
         * Mapper.CreateMap<Category, CategoryViewModel()
         *              .ForMember(dest => dest.Description, cat => cat.MapFrom(src => src.Description));
         *
         * IGNORE A FIELD
         * 
         * Mapper.CreateMap<Category, CategoryViewModel()
         *              .ForMember(dest => dest.Description, o => o.Ignore);
         */
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Category, CategoryViewModel>().ConvertUsing<CategoryViewModelConverter>();
        }
    }
}