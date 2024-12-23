﻿using App.Services.Products.Create;
using App.Services.Products.Update;
using App.Services.Products.UpdateStock;

namespace App.Services.Products
{
    public interface IProductService
    {
        Task<ServiceResult<List<ProductDto>>> GetTopPriceProductsAsync(int count);
        Task<ServiceResult<ProductDto>> GetByIdAsync(int id);
        Task<ServiceResult<List<ProductDto>>> GetAllListAsync();
        Task<ServiceResult<List<ProductDto>>> GetPagedAllListAsync(int pageNumber, int pageSize);
        Task<ServiceResult<CreateProductResponse>> CreateAsync(CreateProductRequest request);
        Task<ServiceResult> UpdateAsync(int Id, UpdateProductRequest request);
        Task<ServiceResult> UpdateStockAsync(UpdateProductStcokRequest request);
        Task<ServiceResult> DeleteAsync(int Id);
    }
}
