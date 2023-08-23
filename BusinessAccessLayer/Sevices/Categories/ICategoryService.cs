using BusinessAccessLayer.DTOs;
using DataAccessLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Sevices.Categories
{
    public interface ICategoryService
    {
        Task AddCategory(AddCategoryDTO categoryDTO);
        Task UpdateCategory(UpdateCategoryDTO categoryDTO);
        Task DeleteCategory(int id);
        Task<List<GetCategoriesDTO>> GetAllCategories();
    }
}
