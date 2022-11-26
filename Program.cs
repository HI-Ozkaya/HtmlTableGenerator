using System.Text.Json;
using System.Text.Json.Serialization;

string path = Path.Combine(Environment.CurrentDirectory, "movies.json");
string jsonMovies = File.ReadAllText(path);

Console.WriteLine(jsonMovies);