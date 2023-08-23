using AutoMapper;
using BusinessAccessLayer.DTOs;
using DataAccessLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product,AddProductDTO>().ReverseMap();
            CreateMap<Category,AddCategoryDTO>().ReverseMap();
            CreateMap<Product,UpdateProductDTO>().ReverseMap(); 
            CreateMap<Category,UpdateCategoryDTO>().ReverseMap();   
            CreateMap<Category,GetCategoriesDTO>().ReverseMap();    
        }
    }
}
