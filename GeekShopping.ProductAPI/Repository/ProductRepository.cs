using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ProductVO> Create(ProductVO product)
        {
            Product _product = _mapper.Map<Product>(product);
            _context.Products.Add(_product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(_product);
    
        }

        public async Task<bool> DeleteById(long id)
        {
            try
            {
                Product _product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (_product == null) return false;
                _context.Products.Remove(_product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<IEnumerable<ProductVO>> GetAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> GetById(long id)
        {
            Product? product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Update(ProductVO product)
        {
            Product _product = _mapper.Map<Product>(product);
            _context.Products.Update(_product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(_product);
        }
    }
}
