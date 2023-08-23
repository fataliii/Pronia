using Microsoft.EntityFrameworkCore;
using Pronia.Core.Entities;
using System;

namespace Pronia.DataAcces.Contexts;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }
    public DbSet<Service> Services { get; set; } = null!;
    public DbSet<Slider> Sliders { get; set; } = null!;
   
}
