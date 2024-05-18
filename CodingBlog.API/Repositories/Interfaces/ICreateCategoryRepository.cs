using CodingBlog.API.Models.Domain;

namespace CodingBlog.API.Repositories.Interfaces;

public interface ICreateCategoryRepository
{

    public Task<Category> CreateCategoryAsync(Category category);
}
