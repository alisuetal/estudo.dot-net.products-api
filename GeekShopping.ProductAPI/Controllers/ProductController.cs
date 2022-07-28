using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> GetById(long id)
        {
            var _product = await _repository.GetById(id);
            if(_product == null) return NotFound();
            return Ok(_product);
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductVO>>> GetAll()
        {
            var _products = await _repository.GetAll();
            return Ok(_products);
        }
        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create(ProductVO product)
        {
            if (product == null) return BadRequest();
            var _products = await _repository.Create(product);
            return Ok(_products);
        }
        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update(ProductVO product)
        {
            if (product == null) return BadRequest();
            var _products = await _repository.Update(product);
            return Ok(_products);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductVO>> Delete(long id)
        {
            var _product = await _repository.DeleteById(id);
            if (!_product) return BadRequest();
            return Ok(_product);
        }
    }

}
