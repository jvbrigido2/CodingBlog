using CodingBlog.API.Data;
using CodingBlog.API.Models.Domain;
using CodingBlog.API.Repositories.Interfaces;

namespace CodingBlog.API.Repositories.Implementation;

public class CreateCategoryRepository : ICreateCategoryRepository
{
    private readonly AppDbContext _context;

    public CreateCategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    async Task<Category> ICreateCategoryRepository.CreateCategoryAsync(Category category)
    {
        await _context.AddAsync(category);
        await _context.SaveChangesAsync();
        return category;
    }
}
