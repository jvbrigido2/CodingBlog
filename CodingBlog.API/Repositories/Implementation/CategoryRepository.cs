﻿using CodingBlog.API.Data;
using CodingBlog.API.Models.Domain;
using CodingBlog.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CodingBlog.API.Repositories.Implementation;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _context;

    public CategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    async Task<Category> ICategoryRepository.CreateCategoryAsync(Category category)
    {
        await _context.AddAsync(category);
        await _context.SaveChangesAsync();
        return category;
    }
  

    async Task<IEnumerable<Category>> ICategoryRepository.GetAllCategoriesAsync()
    {
        return await _context.Categories.ToListAsync();
    }
}
