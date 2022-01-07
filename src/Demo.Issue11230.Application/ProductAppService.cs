using System;
using Demo.Issue11230.Products;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Issue11230;

public class ProductAppService : CrudAppService<Product,
        ProductDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateProductDto>,
    IProductAppService
{
    public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
    {
    }
}