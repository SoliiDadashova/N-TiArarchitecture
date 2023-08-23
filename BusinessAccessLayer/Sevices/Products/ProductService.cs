using AutoMapper;
using BusinessAccessLayer.DTOs;
using BusinessAccessLayer.Sevices.ProductService.ProductService;
using DataAccessLayer.Data;
using DataAccessLayer.Entites;
using DataAccessLayer.Repositories.Abstraction;
using DataAccessLayer.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Sevices.Products
{
    public class ProductService : IProductService
    {
        public IGenericRepository<Product> _productRepository { get; }
        public IMapper _mapper { get; }
        public ProductService(IGenericRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task AddProduct(AddProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.AddAsync(productEntity);

        }

        public async Task UpdateProduct(UpdateProductDTO productDTO)
        {
            var productEntity = _productRepository.FindAsync(productDTO.ID);
            if (productEntity == null)
            {
                return;
            }

            var result = await _mapper.Map(productDTO, productEntity);
            await _productRepository.Update(result);
        }

        public async Task DeleteProduct(int id)
        {
            await _productRepository.Delete(id);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllAsync();
        }
    }
}

