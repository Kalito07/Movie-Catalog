using Supabase;
using System;
using System.Threading.Tasks;
using System.Linq;
using Supabase.Postgrest.Exceptions;

public class MovieService
{
    private readonly Supabase.Client _client;

    public MovieService(Supabase.Client client)
    {
        _client = client;
    }
    public async Task Initialize()
    {
        var newMovie = new Movie
        {
            Title = "1",
            Description = "1",
            ReleaseYear = 2010,
            GenreId = 1,
            DirectorId = 1, 
            Rating = 8.8
        };

        try
        {
            var response = await _client.From<Movie>().Insert(newMovie);

            if (!response.Models.Any())
            {
                Console.WriteLine("Failed to insert movie - no model returned");
            }
            else
            {
                Console.WriteLine($"Successfully inserted movie: {newMovie.Title}");
            }
        }
        catch (PostgrestException ex)
        {
            Console.WriteLine($"Postgrest Exception: {ex.Message}");
            Console.WriteLine($"Response Content: {ex.Response?.Content}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Exception: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        }

    }

}
