using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
[Table("genres")]
public class Genre : BaseModel
{
    [PrimaryKey("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        return obj is Genre genre &&
               Id == genre.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}