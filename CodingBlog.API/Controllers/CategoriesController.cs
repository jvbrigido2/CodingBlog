using CodingBlog.API.Models.Domain;
using CodingBlog.API.Models.DTOs.Requests;
using CodingBlog.API.Models.DTOs.Responses.CategoryResponses;
using CodingBlog.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CodingBlog.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICreateCategoryRepository _repository;
    
    public CategoriesController(ICreateCategoryRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateCategoryDtoRequest request)
    {
        var category = new Category
        {
            Name = request.Name,
            ImageUrl = request.ImageUrl,
        };

        await _repository.CreateCategoryAsync(category);

        var response = new CreateCategoryDtoResponse
        {
            Id = category.Id,
            Name = category.Name,
            ImageUrl = category.ImageUrl,
        };

        return Ok(response);
    }

}
