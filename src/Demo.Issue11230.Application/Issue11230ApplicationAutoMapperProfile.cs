using AutoMapper;
using Demo.Issue11230.Products;

namespace Demo.Issue11230
{
    public class Issue11230ApplicationAutoMapperProfile : Profile
    {
        public Issue11230ApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Product, ProductDto>();
            CreateMap<CreateUpdateProductDto, Product>();
        }
    }
}
