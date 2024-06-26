﻿using CodingBlog.API.Models.Domain;
using CodingBlog.API.Models.DTOs.Category;
using CodingBlog.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CodingBlog.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryRepository _repository;
    
    public CategoriesController(ICategoryRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
    {
        var category = new Category
        {
            Name = request.Name,
            ImageUrl = request.ImageUrl,
        };

        await _repository.CreateCategoryAsync(category);

        var response = new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            ImageUrl = category.ImageUrl,
        };

        return Ok(response);
    }
    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await _repository.GetAllCategoriesAsync();

        var response = new List<CategoryDto>();

        foreach(var category in categories)
        {
            var categoryDto = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                ImageUrl = category.ImageUrl,
            };
            response.Add(categoryDto);
        }
        return Ok(response);
    }

}
