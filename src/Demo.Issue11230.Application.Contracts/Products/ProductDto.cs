using System;
using Volo.Abp.Application.Dtos;

namespace Demo.Issue11230.Products;

public class ProductDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string Description { get; set; }
}