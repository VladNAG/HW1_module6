using HW2_module6.Entityes;
using HW2_module6.Interfeces;
using Microsoft.AspNetCore.Mvc;

namespace HW2_module6.Controlers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServise _productService;

        public ProductController(IProductServise productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public Product[] GetAllProduct()
        {
            return _productService.GetAll();
        }

        [HttpGet]
        [Route("/[controller]/{id}")]
        public Product GetProductById(int id)
        {
            return _productService.Get(id);
        }

        [HttpPost]
        public void CreateNewProduct([FromBody] Product product)
        {
            _productService.Create(product);
        }

        [HttpPut]
        public void UpdateProduct(Product product)
        {
            _productService.Update(product);
        }

        [HttpDelete]
        public void DeleteProductById(int id)
        {
            _productService.Delete(id);
        }
    }
}
