using Microsoft.EntityFrameworkCore;


public class Context : DbContext
{
    public DbSet<Payments> Payment { get; set; }

    public Context(DbContextOptions<Context> option) : base(option)
    {
        
    }
}