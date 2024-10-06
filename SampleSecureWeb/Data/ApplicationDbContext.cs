using System;
using Microsoft.EntityFrameworkCore;
using SampleSecureWeb.Models;

namespace SampleSecureWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;

}
