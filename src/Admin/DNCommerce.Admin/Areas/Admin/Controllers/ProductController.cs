using System.Threading.Tasks;
using DNCommerce.Admin.Areas.Admin.Models;
using DNCommerce.Framework.BuildingBlocks.Catalog.DTO.Contracts;
using DNCommerce.Framework.BuildingBlocks.Catalog.Services;
using Microsoft.AspNetCore.Mvc;

namespace DNCommerce.Admin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductDtoFactory _productDtoFactory;

        public ProductController(IProductService productService, IProductDtoFactory productDtoFactory)
        {
            _productService = productService;
            _productDtoFactory = productDtoFactory;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProductsAsync();
            return View(products);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            var model = new InsertProductViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(InsertProductViewModel model)
        {
            var productDto = _productDtoFactory.InsertProductDto(model.Title, model.Description, model.Feature, model.Price, model.QuantityInStock, model.Weight);
            await _productService.InsertProductAsync(productDto);
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            var model = new UpdateProductViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductViewModel model)
        {
            var productDto = _productDtoFactory.UpdateProductDto(model.Id, model.Title, model.Description, model.Feature, model.Price, model.QuantityInStock, model.Weight);
            await _productService.UpdateProductAsync(productDto);
            return View();
        }
    }
}
