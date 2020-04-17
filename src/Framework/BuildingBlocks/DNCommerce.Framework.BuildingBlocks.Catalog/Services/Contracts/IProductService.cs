using System.Threading.Tasks;
using DNCommerce.Framework.BuildingBlocks.Catalog.DTO;

namespace DNCommerce.Framework.BuildingBlocks.Catalog.Services
{
    public interface IProductService
    {
        Task<ProductListDto> GetAllProductsAsync();
        Task InsertProductAsync(InsertProductDto insertProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
    }
}