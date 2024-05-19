using CodingBlog.API.Models.Domain;

namespace CodingBlog.API.Repositories.Interfaces;

public interface ICategoryRepository
{

    public Task<Category> CreateCategoryAsync(Category category);

    public Task<IEnumerable<Category>> GetAllCategoriesAsync();
}
