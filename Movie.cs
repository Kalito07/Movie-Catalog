using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[System.ComponentModel.DataAnnotations.Schema.Table("movies")]
public class Movie : BaseModel
{
    
    [PrimaryKey("id")]
    public int Id { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.Column("title")]
    public string Title { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.Column("description")]
    public string Description { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.Column("release_year")]
    public int? ReleaseYear { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.Column("genre_id")]
    public int? GenreId { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.Column("director_id")]
    public int? DirectorId { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.Column("rating")]
    public double? Rating { get; set; } = 0;

    public virtual Genre Genre { get; set; }
    public virtual Director Director { get; set; }

    public override bool Equals(object obj)
    {
        return obj is Movie movie &&
               Id == movie.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}





