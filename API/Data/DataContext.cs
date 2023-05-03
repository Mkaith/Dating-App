using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //we will be using DbContext as a service which will be injected in classes wherever required
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
  }
}