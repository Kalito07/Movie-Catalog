using Microsoft.EntityFrameworkCore;
using Movie_Catalog.Data.Models;

public class MovieCatalogContext : DbContext
{
    public MovieCatalogContext(DbContextOptions<MovieCatalogContext> options) : base(options)
    {
        
    }
    public DbSet<Movie> Movies { get; set; }
}