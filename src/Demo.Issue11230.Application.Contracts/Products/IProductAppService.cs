using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Issue11230.Products;

public interface IProductAppService :
    ICrudAppService<
        ProductDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateProductDto>
{
}