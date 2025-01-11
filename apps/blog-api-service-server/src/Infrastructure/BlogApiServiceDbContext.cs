using Microsoft.EntityFrameworkCore;

namespace BlogApiService.Infrastructure;

public class BlogApiServiceDbContext : DbContext
{
    public BlogApiServiceDbContext(DbContextOptions<BlogApiServiceDbContext> options)
        : base(options) { }
}
