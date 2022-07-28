using GeekShopping.ProductAPI.Data.ValueObjects;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> GetAll();
        Task<ProductVO> GetById(long id);
        Task<ProductVO> Update(ProductVO product);
        Task<ProductVO> Create(ProductVO product);
        Task<bool> DeleteById(long id);
    }
}
