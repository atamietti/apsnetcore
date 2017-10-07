using StoreOfBuild.Domain.Dto;

namespace StoreOfBuild.Domain.Products
{
    public class CategoryStorer
    {
        public IRepository<Category> _categoryRepository {get; private set;} 

        public CategoryStorer(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Store(CategoryDto dto)
        {
            var category = _categoryRepository.GetById(dto.Id);

            if(category==null)
            {
                category = new Category(dto.Name);
                _categoryRepository.Save(category);
            }
            else
            {
                category.Update(dto.Name);
            }

        }

    }
}