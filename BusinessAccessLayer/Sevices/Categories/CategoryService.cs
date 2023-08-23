using AutoMapper;
using BusinessAccessLayer.DTOs;
using DataAccessLayer.Entites;
using DataAccessLayer.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Sevices.Categories

{
    public class CategoryService:ICategoryService
    {
        public IGenericRepository<Category> _categoryService { get; }
        public IMapper _mapper { get; }
        public CategoryService(IGenericRepository<Category> categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task AddCategory(AddCategoryDTO categoryDTO)
        {
            var catgoryEntity=_mapper.Map<Category>(categoryDTO);  
            await _categoryService.AddAsync(catgoryEntity);

        }

        public async Task UpdateCategory(UpdateCategoryDTO categoryDTO)
        {
            var entity = await _categoryService.FindAsync(categoryDTO.ID);
            if (entity == null)
            {
                return;
            }
            _mapper.Map(categoryDTO, entity);
            await _categoryService.Update(entity);
        }

        public async Task DeleteCategory(int id)
        {
            await _categoryService.Delete(id);
        }

        public async Task<List<GetCategoriesDTO>> GetAllCategories()
        {
           var category=await _categoryService.GetAllAsync();
           var result=  _mapper.Map<List<GetCategoriesDTO>>(category);
            return result;
           
        }
    }
}
