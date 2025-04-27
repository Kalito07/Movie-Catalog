using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("directors")]
public class Director : BaseModel
{
    [PrimaryKey("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        return obj is Director director &&
               Id == director.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}




