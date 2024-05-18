using CodingBlog.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodingBlog.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options ) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
}
