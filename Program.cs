using System.Text.Json;
using System.Text.Json.Serialization;

string path = Path.Combine(Environment.CurrentDirectory, "movies.json");
string jsonMovies = File.ReadAllText(path);

List<Movie> Movies;

JsonSerializerOptions options = new();
options.PropertyNameCaseInsensitive = true;

Movies = JsonSerializer.Deserialize<List<Movie>>(jsonMovies, options);

foreach (var item in Movies)
{
    Console.WriteLine(item.Title);
}