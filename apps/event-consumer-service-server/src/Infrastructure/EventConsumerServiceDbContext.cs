using Microsoft.EntityFrameworkCore;

namespace EventConsumerService.Infrastructure;

public class EventConsumerServiceDbContext : DbContext
{
    public EventConsumerServiceDbContext(DbContextOptions<EventConsumerServiceDbContext> options)
        : base(options) { }
}
