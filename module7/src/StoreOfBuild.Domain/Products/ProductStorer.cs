using StoreOfBuild.Domain.Dto;

namespace StoreOfBuild.Domain.Products
{
    public class ProductStorer
    {
        public IRepository<Product> _productRepository {get; private set;} 
        public IRepository<Category> _categoryRepository {get; private set;} 

        public ProductStorer(IRepository<Product> productRepository, IRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public void Store(ProductDto dto)
        {
            var category = _categoryRepository.GetById(dto.Category);
            DomainException.When(category == null, "Category invalid");

            var product = _productRepository.GetById(dto.Id);

            if(product==null)
            {
                product = new Product(dto.Name, category,dto.Price,dto.StockQuantity);
                _productRepository.Save(product);

            }else
            {
                product.Update(dto.Name, category,dto.Price,dto.StockQuantity);
            }
        }
    }
}