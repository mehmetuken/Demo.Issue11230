using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Identity;
using Xunit;

namespace Demo.Issue11230.Products;

public class ProductAppServiceTest : Issue11230ApplicationTestBase
{
    private readonly IProductAppService _productAppService;

    public ProductAppServiceTest()
    {
        _productAppService = GetRequiredService<IProductAppService>();
    }

    [Fact]
    public async Task Check_Creation_Time_Change_Update()
    {
        var createResult = await _productAppService.CreateAsync(new CreateUpdateProductDto
        {
            Name = "test fact",
            Description = "test fact"
        });

        var updateResult = await _productAppService.UpdateAsync(createResult.Id, new CreateUpdateProductDto
        {
            Name = "test fact",
            Description = "test fact"
        });

        updateResult.CreationTime.ShouldBe(createResult.CreationTime);
    }
}