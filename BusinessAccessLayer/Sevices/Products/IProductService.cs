using BusinessAccessLayer.DTOs;
using DataAccessLayer.Entites;
using DataAccessLayer.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Sevices.ProductService.ProductService
{
    public interface IProductService
    {
        Task AddProduct(AddProductDTO productDTO);
        Task UpdateProduct(UpdateProductDTO productDTO);
        Task DeleteProduct(int id);
        Task<List<Product>> GetAllProducts();

    }

}
