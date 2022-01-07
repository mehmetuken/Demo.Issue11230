using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Issue11230.Products;

public class Product : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
}