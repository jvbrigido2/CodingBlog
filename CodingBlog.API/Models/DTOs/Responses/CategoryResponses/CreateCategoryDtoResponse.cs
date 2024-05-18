namespace CodingBlog.API.Models.DTOs.Responses.CategoryResponses;

public class CreateCategoryDtoResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string ImageUrl { get; set; }
}
